using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Scirpt : MonoBehaviour
{
    public bool Left;
    public bool Middle;
    public bool Right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Animator DoorAnimator = gameObject.GetComponent<Animator>();
        //this was supposed to be the script for a maze idea
        Left = DoorAnimator.GetBool("Switch Left");
        Middle = DoorAnimator.GetBool("Switch Middle");
        Right = DoorAnimator.GetBool("Switch Right");
        //checks for if the bools are in the right order
        if (!Left && Middle && !Right)
        {
            //THEN YOU SHALL PAAASSS!!
            DoorAnimator.SetBool("OPEN", true);
        }
    }
}
