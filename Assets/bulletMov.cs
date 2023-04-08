using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMov : MonoBehaviour
{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);

     
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "meteors")
        {
            
            scoreSystem.score += 5;
            Destroy(gameObject);
        }

    }
}
