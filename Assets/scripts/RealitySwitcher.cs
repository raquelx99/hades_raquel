using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;

public class RealitySwitch : MonoBehaviour
{
    public GameObject spaceshipReality;
    public GameObject houseReality;
    public GameObject transitionEffect; 
    public UnityEvent FirstSwitch;


    private bool isInSpaceship = true;

    private XRGrabInteractable grabInteractable;
    private int switches = 0;

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
        switches++;

        if(switches <= 1){
            FirstSwitch.Invoke();
        }
    }
}
