using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keyboard : MonoBehaviour
{

    public TextMeshPro display;
    private string correctPassword = "Alistair Blackwood";
    // Desbloqueia info no Monitor principal
    private string enteredPassword = "";

    public void AddDigit(string digit)
    {
        if(enteredPassword.Length < correctPassword.Length){
            enteredPassword += digit;
            UpdateDisplay();
        }
    }

    private void UpdateDisplay()
    {
        display.text = enteredPassword;
    }

    public void CheckCode()
    {
        if(enteredPassword == correctPassword){
            display.text = "LIBERADO";
            // fazer info ser exibida no outro monitor
        }
        else{
            display.text = "SENHA INCORRETA";
            StartCoroutine(ResetCode());
        }
    }

    public void DeleteDigit()
    {
        if (enteredPassword.Length > 0)
            {
                enteredPassword = enteredPassword.Substring(0, enteredPassword.Length - 1);
                UpdateDisplay();
            }
    }

    private IEnumerator ResetCode()
    {
        yield return new WaitForSeconds(1.5f);
        enteredPassword = "";
        display.text = "" ;
    }
}
