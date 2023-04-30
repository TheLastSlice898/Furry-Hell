using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class psydocode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
}

/*
Death Script        

When the player collides with the death pit 
{
    if the game object that collides name is player 
    {
        log "player died"
        Load the scene
    }
}



ButtonandTrigger Script

on Update 
    {
        if mouse button down 
        {
            check if the play is in the trigger volume 
            {
                set animator button to pressed 
            }

        }
    }

OnTriggerStay
    {
        if the game object that collides name is player 
        {
            set animator bool to ture 
           set is player inside the volume to true
        }
    }
OnTriggerExit
    {
        set animator bool to flase 
           set is player inside the volume to false 



Door Script


OnTriggerEnter
    {
        if the game object that collides name is player 
        {
            check if the door is open 
            {
                make door close 
            }
            else if the door is closed 
            {
                make the door open 
            }
        }


Tutorial Popup

OnTriggerEnter
    {
        Set tutorial box game object active 
        turn the player movement off 
        uplock the cursor 
    }


    public void Exit()
    {
        Set tutorial box game object deactiveated.
        turn the player movement on
        lock the cursor 
 */













