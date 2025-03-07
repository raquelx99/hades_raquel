using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RealitySwitch : MonoBehaviour
{
    public GameObject spaceshipReality;
    public GameObject houseReality;
    public GameObject transitionEffect; 

    private bool isInSpaceship = true;

    private XRGrabInteractable grabInteractable;

    void Start()
    {
        spaceshipReality.SetActive(isInSpaceship);
        houseReality.SetActive(!isInSpaceship);

        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(OnGrabbed);

    }

    void OnGrabbed(SelectEnterEventArgs args){
        SwitchReality();
    }

    public void SwitchReality()
    {
       
        if (transitionEffect)
        {
            Instantiate(transitionEffect, transform.position, Quaternion.identity);
        }

        isInSpaceship = !isInSpaceship;
        spaceshipReality.SetActive(isInSpaceship);
        houseReality.SetActive(!isInSpaceship);
    }
}
