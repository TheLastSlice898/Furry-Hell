using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonandTrigger : MonoBehaviour
{

    public bool IsPlayerTrigger;
    public Animator ButtonAnimator;
    public Animator DoorAnimator;

    public GameObject UI_Button;

    public string Trigger;
    public string Bool;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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
            UI_Button.SetActive(true);
            IsPlayerTrigger = true;
        }
    }
    void OnTriggerExit(Collider Trigger)
    {
        IsPlayerTrigger = false;
        UI_Button.SetActive(false);
    }
}
