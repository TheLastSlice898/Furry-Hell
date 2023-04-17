using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Acceleration, MouseSesitivity, PlayerSesitivity, jumpForce, Speed, MaxSpeed;

    public Rigidbody playerBody;
    public Camera PlayerCamera;

    private Vector3 playerMovementInput;

    float moveX;
    float moveY;
    public bool IsGrounded;
    public bool DoubleJump;

    float xRotation;
    float yRotation;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //make the keyboard inputs a vector 3 
        //playerMouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        moveX = Input.GetAxis("Vertical");
        moveY = Input.GetAxis("Horizontal");

        Vector3 PlayerInputV3 = new Vector3(moveY, 0f, moveX);
        playerMovementInput = PlayerInputV3 * PlayerSesitivity;

        Debug.Log(PlayerInputV3);

        float MouseX = Input.GetAxis("Mouse X") * Time.deltaTime * (100 * MouseSesitivity);
        float MouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * (100 * MouseSesitivity);

        xRotation -= MouseY;
        yRotation += MouseX;

        //makes the rotation between -90 and 90 degrees 
        xRotation = Mathf.Clamp(xRotation, -56f, 56f);


        PlayerCamera.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);

        //using the mouse input to make a vector 3 to rotate the player left and right 
        Vector3 MouseInputHoriz = new Vector3(0f, MouseX, 0f);
        Quaternion MouseRotationHoriz = Quaternion.Euler(MouseInputHoriz);
        playerBody.MoveRotation(playerBody.rotation * MouseRotationHoriz);

        if (Speed >= MaxSpeed)
        {
            Speed = MaxSpeed;
            Vector3 MoveVector = transform.TransformDirection(playerMovementInput) * MaxSpeed;
            playerBody.velocity = new Vector3(MoveVector.x, playerBody.velocity.y, MoveVector.z);
        }
        else
        {
            Speed += Acceleration * Time.deltaTime;
            Vector3 MoveVector = transform.TransformDirection(playerMovementInput) * Speed;
            playerBody.velocity = new Vector3(MoveVector.x, playerBody.velocity.y, MoveVector.z);
        }

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
        {
            playerBody.velocity = new Vector3(playerBody.velocity.x, 0f, playerBody.velocity.z);
            playerBody.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            IsGrounded = false;
            DoubleJump = true;

        }
        else if (Input.GetKeyDown(KeyCode.Space) && DoubleJump)
        {
            playerBody.velocity = new Vector3(playerBody.velocity.x, 0f, playerBody.velocity.z);
            playerBody.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            DoubleJump = false;
        }

        if (PlayerInputV3 == new Vector3(0f, 0f, 0f))
        {
            Speed = 10;
        }

        if (IsGrounded == false)
        {

        }

        //using the mouse to rotate the camera up and down


        //run move player function every frame hmm

        // im so dumb TWT (COULD BE USED AS GUN OWO)
        //Ray Raycast = new Ray (playerBody.transform.position, -playerBody.transform.up);
        //Physics.Raycast(playerBody.transform.position, -playerBody.transform.up, Mathf.Infinity);
        //RaycastHit Hit = new RaycastHit();
        //if (Hit.distance <= 0f)
        //{
        //    IsGrounded = true;
        //}
        //else 
        //{
        //    IsGrounded = false;
        //}
        //Debug.DrawRay(Raycast.origin, Raycast.direction * 1);
    }

void OnCollisionEnter(Collision Collider)
    {
    if (Collider.gameObject.tag == "Floor")
        {
            IsGrounded = true;
            DoubleJump = false;
            MouseSesitivity = 2.5f;
        }
    }
}