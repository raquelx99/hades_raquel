using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PuzzleSocketController : MonoBehaviour
{
    public XRSocketInteractor socket1;
    public XRSocketInteractor socket2;
    public XRSocketInteractor socket3;
    
    public GameObject painelEscolhaFinal;

    void Start()
    {
        socket1.selectEntered.AddListener(CheckSockets);
        socket1.selectExited.AddListener(CheckSockets);

        socket2.selectEntered.AddListener(CheckSockets);
        socket2.selectExited.AddListener(CheckSockets);

        socket3.selectEntered.AddListener(CheckSockets);
        socket3.selectExited.AddListener(CheckSockets);

        painelEscolhaFinal.SetActive(false);
    }

    private void CheckSockets(SelectEnterEventArgs args)
{
    if (TodosSocketsOcupados())
    {
        painelEscolhaFinal.SetActive(true);
    }
}

    private void CheckSockets(SelectExitEventArgs args)
    {
        if (TodosSocketsOcupados())
        {
            painelEscolhaFinal.SetActive(true);
        }
    }

    private bool TodosSocketsOcupados()
    {
        return socket1.hasSelection && socket2.hasSelection && socket3.hasSelection;
    }
}