using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class DoorTrigger : MonoBehaviour
{
    public GameObject Door;

    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = Door.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider DoorTrigger)
    {
        if (DoorTrigger.gameObject.name == "Player")
        {
            if (m_Animator.GetBool("OPEN"))
            {
                m_Animator.SetBool("OPEN", false);
            }
            else
            {
                m_Animator.SetBool("OPEN", true);
            }
        }

    }
}
