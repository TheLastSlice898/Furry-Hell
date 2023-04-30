using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{

    public bool IsPlayerTrigger;
    public Animator ButtonAnimator;
    public Animator DoorAnimator;

    public GameObject UI_Button;

    public string SwitchName;
    public string Bool;

    public bool SwitchMode;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //get the bool from the animator
        SwitchMode = ButtonAnimator.GetBool(Bool);
        //Set the bool on the animator to the bool 
        DoorAnimator.SetBool(SwitchName, SwitchMode);
        if (IsPlayerTrigger) 
        {
            //if the player presses f then set the animator to oppisite of the bool
            if (Input.GetKeyDown("f"))
            {
                ButtonAnimator.SetBool(Bool,!ButtonAnimator.GetBool(Bool));
            }

        }

    }

    void OnTriggerStay(Collider Trigger)
    {
        //toggles the ui on
        if (Trigger.gameObject.name == "Player")
        {
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
