using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBus : MonoBehaviour
    
{
    private static EventBus _current;
    public static EventBus current {  get { return _current; } }
    // Start is called before the first frame update
    private int Lives = 3;
    public string name = "Cumslor";
    

        //fuction to lower Lives
    public void LowerLife()
    {
        Lives = Lives -1;
        Debug.Log(Lives);
    }

    private void Awake()
    {
        if (_current != null && _current != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _current = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public event Action Poggers;

    public void PoggersTrigger()
    {
        Poggers();
    }

     public event Action LightGoOn;
    
    public void LightGoOnTrigger()
    {
        LightGoOn();
    }
     public event Action LightGoOff;
    
    public void LightGoOffTrigger()
    {
        LightGoOff();
    }
}
