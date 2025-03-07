using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CadeadoBau : MonoBehaviour
{

    public Animator chestAnimator;
    public XRSocketTagInteractor socketTagInteractor;
    private bool isUnlocked = false;

    // Start is called before the first frame update
    void Start()
    {
        if(socketTagInteractor != null)
        {
            socketTagInteractor.selectEntered.AddListener(onKeyInserted);
        }
    }

    private void onKeyInserted(SelectEnterEventArgs args)
    {
        if (!isUnlocked){
            isUnlocked = true;
            chestAnimator.Play("BauAbrindo");
            gameObject.SetActive(false);
        }
    }
}
