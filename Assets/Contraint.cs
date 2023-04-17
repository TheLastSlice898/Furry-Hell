using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contraint : MonoBehaviour
{
    public Transform Transform;
    public float Uppercontraint;
    public float Lowercontraint;

    public float MinAngle;
    public float MaxAngle;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {


       //if (Transform.transform.localRotation.x > Lowercontraint)
       //{
       //    Debug.Log("FUCK TO LOW");
       //     Transform.transform.eulerAngles = new Vector3 (Mathf.Clamp(Transform.rotation.eulerAngles.x, -30f, 30f),transform.transform.eulerAngles.y, transform.transform.eulerAngles.z);
       //}
       //
       //if (Transform.transform.rotation.x > Uppercontraint)
       //{
       //    Debug.Log("FUCK TO HIGH");
       //    Transform.transform.eulerAngles = new Vector3(MaxAngle, transform.eulerAngles.y, transform.eulerAngles.z);
       //}
    }
}
