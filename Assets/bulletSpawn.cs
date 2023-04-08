using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpawn : MonoBehaviour
{
    public GameObject bulletPrefab;
    private float fireRate = 0.4f, canFire = -1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.Space) && Time.time>canFire)
        {
            canFire = Time.time + fireRate;
            var clone = Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
            Destroy(clone, 6f);
        }*/
    }
    public void FireButton()
{
    if (Time.time > canFire)
    {
        canFire = Time.time + fireRate;
        var clone = Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
        Destroy(clone, 6f);
    }
}
}
