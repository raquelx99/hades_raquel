using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keyboard : MonoBehaviour
{

    public TextMeshProUGUI display;
    public GameObject diario;
    public GameObject estrela;
    private string correctPassword = "ALISTAIR BLACKWOOD";
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
            diario.SetActive(true);
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
