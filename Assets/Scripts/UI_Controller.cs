using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Controller : MonoBehaviour
{
    int lives; 
    public TextMeshProUGUI LivesCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //sets the lives counter to the lives on the event bus
        lives = EventBus.Current.LivesGet();
        LivesCounter.text = lives.ToString();
    }
}
