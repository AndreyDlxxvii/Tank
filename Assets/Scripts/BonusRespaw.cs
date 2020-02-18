using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusRespaw : MonoBehaviour
{ 

    public GameObject[] prefab;
    public Transform[] spawnPoint;
    public float lifeRespawn;
    private int spawnIndexHeal, spawnIndexMine;

    
    void Start()
    {
    InvokeRepeating("BonusRespawn", 0, 10);
    }



    void BonusRespawn()
    {
        spawnIndexHeal = Random.Range(0, spawnPoint.Length);
        spawnIndexMine = Random.Range(0, prefab.Length);
        GameObject bonus = Instantiate(prefab[spawnIndexMine], spawnPoint[spawnIndexHeal].position, Quaternion.identity);
        Destroy(bonus, lifeRespawn);

    }
    void Update()
    {

    }
    }