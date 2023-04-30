using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventBus : MonoBehaviour

{
    private static EventBus _current;
    private int Lives = 3;
    public static EventBus Current { get { return _current; } }
    // Start is called before the first frame update
    public string name = "Cumslor";


    //fuction to lower Lives
    public void LowerLife()
    {
        Lives = Lives - 1;
        Debug.Log(Lives);

        if (Lives < 0)
        {
            SceneManager.LoadScene(0);
            Lives = 3;
        }
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

    public event Action CubeGoOn;

    public void CubeGoOnTrigger()
    {
        CubeGoOn();
    }
    public event Action CubeGoOff;
    public void CubeGoOffTrigger()
    {
        CubeGoOff();
    }

    public int LivesGet()
    {
        return Lives;
    }


}
