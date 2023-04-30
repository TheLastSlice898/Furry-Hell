using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class MoveTo : MonoBehaviour
{
    public Transform goal;

    // Start is called before the first frame update
    void Start()
    {               
    }

    // Update is called once per frame
    void Update()
    { 
        //get the agent and make the destination the goal position. 
        NavMeshAgent agent = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = goal.position;
    }
}
