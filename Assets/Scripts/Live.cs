using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Live : MonoBehaviour
{ public int live;

    private void OnGUI()
    {
        GUI.Label(new Rect(0, 25, 50, 20), live.ToString());
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.tag);

        string selection = collision.gameObject.tag;
       switch (selection)
        {
            case "Shell":
                LiveSubtrack(10);
                break;
            case "ShellHard":
                LiveSubtrack(20);
                break;
            case "ShellKill":
                LiveSubtrack(100);
                break;
            //case "Mine":
            //    LiveSubtrack(10);
            //    break;

        }

    }

    public void LiveSubtrack(int power)
    {
        live -= power;
    }

    public void LiveAdd()
    {
        live += 10;
        live = Mathf.Clamp(live, 0, 100);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
