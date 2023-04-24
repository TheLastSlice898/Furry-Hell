using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{


    private float LightTimeOff;
    private float LightTimeOn;

    private bool LightState;
    // Start is called before the first frame update
    void Start()
    {
        LightTimeOn = Random.Range(1f,4f);
    }

    // Update is called once per frame
    void Update()
    {
        if (LightState) {
            LightTimeOff -= Time.deltaTime;
            if (LightTimeOff <= 0f)
            {
            EventBus.current.LightGoOnTrigger();
            LightState = !LightState;
            LightTimeOn = Random.Range(1f,4f);
            }
        
        else
            {
        LightTimeOn -= Time.deltaTime;
         if (LightTimeOn <= 0f)
                {
            EventBus.current.LightGoOffTrigger();
            LightState = !LightState;
            LightTimeOff = Random.Range(1f,4f);
                }
            }
        
        }
    }
}