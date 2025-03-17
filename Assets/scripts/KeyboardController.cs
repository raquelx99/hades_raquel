using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Keyboard : MonoBehaviour
{

    public TextMeshProUGUI display;
    public GameObject diario;
    public GameObject estrela;
    private string correctPassword = "ALISTAIR BLACKWOOD";
    private string enteredPassword = "";
    public UnityEvent Solved;

    void Start()
    {
        estrela.SetActive(false);
    }

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
            display.text = "ACESSO LIBERADO";
            diario.SetActive(true);
            estrela.SetActive(true);
            Solved.Invoke();
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
