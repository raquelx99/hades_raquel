using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadController : MonoBehaviour
{
    public TextMeshPro display;
    private string correctCode = "2495";
    public Animator doorAnimator;
    public string boolName = "Open";

    private string enteredCode = "";

    public void AddDigit(string digit)
    {
        if(enteredCode.Length < correctCode.Length){
            enteredCode += digit;
            UpdateDisplay();
        }
    }

    private void UpdateDisplay()
    {
        display.text = enteredCode;
    }

    public void CheckCode()
    {
        if(enteredCode == correctCode){
            display.text = "LIBERADO";
            doorAnimator.SetBool("Open", true);
        }
        else{
            display.text = "ERRO";
            StartCoroutine(ResetCode());
        }
    }

    public void DeleteDigit()
    {
        if (enteredCode.Length > 0)
            {
                enteredCode = enteredCode.Substring(0, enteredCode.Length - 1);
                UpdateDisplay();
            }
    }

    private IEnumerator ResetCode()
    {
        yield return new WaitForSeconds(1.5f);
        enteredCode = "";
        display.text = "" ;
    }
}
