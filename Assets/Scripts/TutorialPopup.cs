using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPopup : MonoBehaviour
{
    public GameObject TutorialBox;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider Trigger)
    {
        Player.GetComponent<PlayerController>().enabled = false;
        Input.ResetInputAxes();
        Player.GetComponent<PlayerController>().moveX = 0f;
        Player.GetComponent<PlayerController>().moveY = 0f;
        TutorialBox.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
    }


    public void Exit()
    {
        TutorialBox.SetActive(false);
        Player.GetComponent<PlayerController>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
