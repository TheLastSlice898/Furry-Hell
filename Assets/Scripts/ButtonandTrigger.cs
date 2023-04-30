using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonandTrigger : MonoBehaviour
{

    public bool IsPlayerTrigger;
    public GameObject Pannel;

    Animator PannelAnimator;
    // Start is called before the first frame update
    void Start()
    {
        PannelAnimator = Pannel.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (IsPlayerTrigger)
            {
                PannelAnimator.SetTrigger("Press Button");
            }

        }
    }

    void OnTriggerStay(Collider Trigger)
    {
        if (Trigger.gameObject.name == "Player")
        {
            PannelAnimator.SetBool("Button Door", true);
            IsPlayerTrigger = true;
        }
    }
    void OnTriggerExit(Collider Trigger)
    {
        PannelAnimator.SetBool("Button Door", false);
        IsPlayerTrigger = false;
    }
}
