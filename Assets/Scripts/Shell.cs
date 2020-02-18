using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public GameObject explosive;
    private GameObject eplosiveInst;
    void Start()
    {
        Destroy(gameObject, 20);
    }

    private void OnCollisionEnter(Collision collision)
    {
        eplosiveInst = Instantiate(explosive, transform.position, Quaternion.identity) as GameObject;
        Destroy(eplosiveInst , 2f);
        Destroy(gameObject);
       
    }

   
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 10);
    }
}
