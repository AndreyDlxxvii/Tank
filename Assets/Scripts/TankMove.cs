using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{
    public float moveSpeed, rotateSpeed, rotateTowerSpeed;
    public GameObject tower;
    public GameObject [] shell;
    public Transform cannon;
    public GameObject explosive;
    private GameObject explosiveInsta;
    public GameObject effect;

    private float move, rotate;
    private float rotateTower;
    private Rigidbody rigidbody;
    private int shellCount;
    private GameObject shellVre;
    private ParticleSystem particle;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        shellVre = shell[0];
        particle = effect.GetComponent<ParticleSystem>();
    }

    private void FixedUpdate()
    {
        Move();
        Turn();
        TurnTower();

    }

    public void Hi()
    {

    }

    private void TurnTower()
    {
        tower.transform.Rotate(Vector3.up, rotateTower * rotateSpeed * Time.deltaTime, Space.World);
    }

    private void Turn()
    {
        float turn = rotate * rotateSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rigidbody.MoveRotation(rigidbody.rotation * turnRotation);

    }

    private void Move()
    {
        Vector3 movement = transform.forward * move * moveSpeed * Time.deltaTime;
        rigidbody.MovePosition(rigidbody.position + movement);
        particle.Play();
        
    }

    private void Fire()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(shellVre, cannon.position, cannon.rotation);
            explosiveInsta = Instantiate(explosive, cannon.position, cannon.rotation) as GameObject;
            Destroy(explosiveInsta, 2f);
        }
    }

    void Update()
    {
        move = Input.GetAxis("Vertical");
        rotate = Input.GetAxis("Horizontal");
        rotateTower = Input.GetAxis("Horizontal1");

        Fire();
        SetShell();

        

    }

    private void SetShell()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            shellCount++;
            if (shellCount <= 2 && shellCount <= 2)
            {
                shellVre = shell[shellCount];

            }
            else
            {
                shellCount = 0;
                shellVre = shell[shellCount];
            }
        }
    }
}


