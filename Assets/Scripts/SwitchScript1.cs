using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript1 : MonoBehaviour
{

    public bool IsPlayerTrigger;
    public Animator ButtonAnimator;
    public GameObject UI_Button;
    public string Bool;

    public bool SwitchMode;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //This makes a local variable for the animator bool 
        SwitchMode = ButtonAnimator.GetBool(Bool);
        if (IsPlayerTrigger) 
        {
            if (Input.GetKeyDown("f"))
            {
                ButtonAnimator.SetBool(Bool,!ButtonAnimator.GetBool(Bool));
            }

        }

    }

    void OnTriggerStay(Collider Trigger)
    {
        if (Trigger.gameObject.name == "Player")
        {
            //toggles the ui on
            UI_Button.SetActive(true);
            IsPlayerTrigger = true;
        }
    }
    void OnTriggerExit(Collider Trigger)
    {
        //toggles the ui off
        IsPlayerTrigger = false;
        UI_Button.SetActive(false);
    }
}
