using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{

    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        /*

        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⡋⢹⣿
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠛⠁⠀⠀⣘⣿
        ⣿⣿⣿⣿⣿⡛⠉⠘⠁⠀⠀⣀⠄⢨⣾⣿
        ⣿⡿⠿⠛⡳⠀⠀⠻⠀⠐⠩⡁⢶⣿⣿⣿ Merp!
        ⣿⣦⡤⠊⠀⠀⠀⠀⠀⠀⠈⠲⢠⡹⢿⣿  Never Trust a sergal     
        ⡿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⢹
        ⣷⡤⠤⠤⡐⠊⠀⠀⠀⠀⠀⠀⠀⠠⣰⣿
        ⣿⡇⠀⠀⠄⠈⠀⠀⡀⠀⠀⠐⠀⢰⣿⣿
        ⣿⠃⡀⠀⠀⠁⠈⠀⠀⠀⠀⠀⠀⣾⣿⣿
        ⣿⣾⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿
        ⣿⣿

        */
    }

    // Update is called once per frame
    void Update()
    {

        //grabs the Variables from the player Controller Script
        Animator PlayerAnimator = gameObject.GetComponent<Animator>();
        bool IsGrounded = Player.GetComponent<PlayerController>().IsGrounded;
        bool DoubleJump = Player.GetComponent<PlayerController>().DoubleJump;
        bool IsFalling = Player.GetComponent<PlayerController>().IsFalling;
        float InputX = Input.GetAxis("Vertical");
        float InputY = Input.GetAxis("Horizontal");

        //Sets the Associated Bool on the animator to its resepctive Variable
        PlayerAnimator.SetFloat("Vertical", InputX);
        PlayerAnimator.SetFloat("Horizontal", InputY);
        PlayerAnimator.SetBool("DoubleJump", DoubleJump);
        PlayerAnimator.SetBool("IsGrounded", IsGrounded);
        PlayerAnimator.SetBool("IsFalling", IsFalling);
        PlayerAnimator.SetBool("Jump", Input.GetKey(KeyCode.Space));

        //if the player do nothing go idle
        if (InputX == 0f && InputY == 0f)
        {
            PlayerAnimator.SetBool("Idle", true);
        }

        
    }
}
