using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerSpawn : MonoBehaviour
{
    float timer;
    public GameObject[] powerUps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer > 25)
        {
            int num = Random.Range(0, powerUps.Length);
            var clone = Instantiate(powerUps[num], transform.position, powerUps[num].transform.rotation);
            Destroy(clone, 3f);
            timer = 12;
        }
    }
}
