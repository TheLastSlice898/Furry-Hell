using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventBus.Current.CubeGoOff += CubeOff;
        EventBus.Current.CubeGoOn += CubeOn;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CubeOff()
    {
        gameObject.SetActive(false);
    }

    public void CubeOn()
    {
        gameObject.SetActive(true);
    }

    void OnDestroy()
    {
        EventBus.Current.CubeGoOn -= CubeOn;
        EventBus.Current.CubeGoOff -= CubeOff;
    }
}
