using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorMovEasy : MonoBehaviour
{
    public float speed;
    public Animator animE;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            
            animE.SetTrigger("explosionEasy");
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.tag == "player")
        {

            Destroy(gameObject);

        }


    }

}
