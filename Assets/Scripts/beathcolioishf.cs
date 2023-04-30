using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class beathcolioishf : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update

    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Fuck");
        if (collision.gameObject.tag == "Player")
        {
            //loads the current scene bu getting the active scene and loading it. 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //uses the event bus to lower the life of the player by 1
            EventBus.current.LowerLife();
        }
    }
}
