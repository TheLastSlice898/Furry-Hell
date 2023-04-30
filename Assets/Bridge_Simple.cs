using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge_Simple : MonoBehaviour
{
    public GameObject Swich;
    public GameObject Bridge;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //set the bridges active state to what the switch is
        bool Switchmode = Swich.GetComponent<SwitchScript1>().SwitchMode;
        Bridge.SetActive(Switchmode);
    }
}
