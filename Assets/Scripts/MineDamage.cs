using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineDamage : MonoBehaviour
{
    private GameObject vremen;
    private Live liveVremen;
    private void OnCollisionEnter(Collision collision)
    {
        vremen = GameObject.Find("Tank");
        liveVremen = vremen.GetComponent<Live>();

        if (collision.gameObject.name == "Tank")
        {
            liveVremen.LiveSubtrack(10);
            Destroy(gameObject);
            print(collision.gameObject.name);
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
