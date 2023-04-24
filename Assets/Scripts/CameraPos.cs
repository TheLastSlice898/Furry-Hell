using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour
{

    public Transform CamHolder;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Makes the camera holder's postition and rotation the same as the one on the player every update
        transform.position = CamHolder.transform.position;
        transform.rotation = CamHolder.transform.rotation;
    }
}
