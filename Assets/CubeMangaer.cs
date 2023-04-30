using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMangaer : MonoBehaviour
{

    public bool hasEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool Swithcmode = gameObject.GetComponent<SwitchScript1>().SwitchMode;
        if (!hasEvent)
        {
            if (Swithcmode)
            {
                EventBus.Current.CubeGoOnTrigger();
                hasEvent = true;
            }
            if (!Swithcmode)
            {
                EventBus.Current.CubeGoOffTrigger();
                hasEvent = false;
            }
        }

    }
}
