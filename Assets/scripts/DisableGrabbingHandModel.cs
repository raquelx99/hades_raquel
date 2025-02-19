using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class DisableGrabbingHand : MonoBehaviour
{
    public GameObject leftHandModel;
    public GameObject rightHandModel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(HideGrabbingHand);
        grabInteractable.selectExited.AddListener(ShowGrabbingHand);
    }

    public void HideGrabbingHand(SelectedEnterEventArgs args)
    {
        if(args.interactorObject.transform.tag) == "Left Hand"
        {
            leftHandModel.SetActive(false);
        }
        else if(args.interactorObject.transform.tag) == "Right Hand"{
            rightHandModel.SetActive(false);
        }
    }

    public void ShowGrabbingHand(SelectExitEventArgs args)
    {
        if(args.interactorObject.transform.tag) == "Left Hand"
        {
            leftHandModel.SetActive(true);
        }
        else if(args.interactorObject.transform.tag) == "Right Hand"{
            rightHandModel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
