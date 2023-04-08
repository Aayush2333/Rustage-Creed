using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metworSpawn : MonoBehaviour
{
    float timer;
    public GameObject[] enemyPrefabs;
    
    void Start()
    {
        
    }
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer > 2)
        {
            int num = Random.Range(0, enemyPrefabs.Length);
            var clone = Instantiate(enemyPrefabs[num], transform.position, enemyPrefabs[num].transform.rotation);
            Destroy(clone, 6f);
            timer = 0;
        }

    }

}

