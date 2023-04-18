using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventBus.current.LightGoOn += LightON;
        EventBus.current.LightGoOff += LightOFF;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LightON()
    {
        gameObject.GetComponent<Light>().intensity = 10;
    }
     public void LightOFF()
    {
        gameObject.GetComponent<Light>().intensity = 0;
    }
    void OnDestroy(){
        EventBus.current.LightGoOn -= LightON;
        EventBus.current.LightGoOff -= LightOFF;
    }
}
