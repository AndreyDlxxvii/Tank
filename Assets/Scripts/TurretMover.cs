using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMover : MonoBehaviour
{
    public Transform target;
    private float distanse;
    public GameObject shell;
    public Transform cannon;
    private float rechargeTime = 10;
    void Start()
    {
        
    }
    void Update()
    {
        distanse = Vector3.Distance(gameObject.transform.position, target.position);
        

        if (distanse < 20)
        {
            Vector3 relativePos = target.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(relativePos);
            transform.rotation = rotation;

        }
        rechargeTime += Time.deltaTime;

        if (rechargeTime>1 && distanse < 20)
        {
            Instantiate(shell, cannon.position, cannon.rotation);
            rechargeTime = 0;
        }
    }
}
