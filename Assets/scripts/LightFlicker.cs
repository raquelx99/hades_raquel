using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{

    public Light lightPoint;

    public float minTime;
    public float maxTime;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        LightFlickering();
    }

    void LightFlickering(){
        if(timer > 0){
            timer -= Time.deltaTime;
        }

        if(timer <= 0){
            lightPoint.enabled = !lightPoint.enabled;
            timer = Random.Range(minTime, maxTime);
        }
    }
}
