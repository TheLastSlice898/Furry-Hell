using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMangaer : MonoBehaviour
{

    public bool hasEvent;
    // Start is called before the first frame update
    void Start()
    {
        EventBus.Current.CubeGoOnTrigger();  
    }

    // Update is called once per frame
    //aaaaaaaaaaaaaaaaaaaa
    //void Update()
    //{
    //    bool Swithcmode = gameObject.GetComponent<SwitchScript1>().SwitchMode;
    //    if (!hasEvent)
    //    {
    //        if (Swithcmode)
    //        {
    //            
    //            hasEvent = true;
    //        }
    //        if (!Swithcmode)
    //        {
    //            EventBus.Current.CubeGoOffTrigger();
    //            hasEvent = false;
    //        }
    //    }
    //
    //}
}
