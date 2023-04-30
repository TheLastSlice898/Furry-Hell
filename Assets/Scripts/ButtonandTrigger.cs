using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonandTrigger : MonoBehaviour
{

    public bool IsPlayerTrigger;
    public GameObject Pannel;
    public AudioSource Audio;
    Animator PannelAnimator;
    // Start is called before the first frame update
    void Start()
    {
        //addes the PannelAnimator Local Variable
        PannelAnimator = Pannel.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if the player clicks the mouse
        if (Input.GetMouseButtonDown(0))
        {
            if (IsPlayerTrigger)
            {
                //play the animation and play the sound
                PannelAnimator.SetTrigger("Press Button");
                Audio.Play();
            }

        }
    }

    void OnTriggerStay(Collider Trigger)
    {
        if (Trigger.gameObject.name == "Player")
        {
            //if the player is next to the door open the door and set the bool to true
            PannelAnimator.SetBool("Button Door", true);
            IsPlayerTrigger = true;
        }
    }
    void OnTriggerExit(Collider Trigger)
    {
        //if the player is not next to the door open the door and set the bool to false
        PannelAnimator.SetBool("Button Door", false);
        IsPlayerTrigger = false;
    }
}
