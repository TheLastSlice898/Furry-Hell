using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour
{

    public Transform CamHolder;
    // Start is called before the first frame update
    void Start()
    {
       CamHolder.transform.rotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = CamHolder.transform.position;
    }
}
