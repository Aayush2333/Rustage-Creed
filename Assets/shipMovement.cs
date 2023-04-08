using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class shipMovement : MonoBehaviour
{
    private Vector3 touchPosition;
    private Rigidbody2D rb;
    private Vector3 direction;
    private float moveSpeed = 10f;
    float xInput;
    public float speed;
    [SerializeField]
    public static int lives ;
    public GameObject live3, live2, live1, live0;
    public GameObject gameOverPanel;
    public GameObject shield;


    // Use this for initialization
    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        lives = 3;
    }

    // Update is called once per frame
    private void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        transform.position = new Vector2(Mathf.Clamp(transform.position.x + xInput * speed, -2.28f, 2.28f),transform.position.y);

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2(direction.x, 0) * moveSpeed;

            if (touch.phase == TouchPhase.Ended)
                rb.velocity = Vector2.zero;
        }

        
        

    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "meteors")
        {
            Destroy(collision.gameObject);


            lives--;

            if (lives == 0)
            {
                live1.SetActive(false);
                live0.SetActive(true);
                gameOverPanel.SetActive(true);
                Destroy(gameObject);
            }
            
        }
        if(lives == 2)
        {

            live3.SetActive(false);
            live2.SetActive(true);

        }
        if (lives == 1)
        {
            live2.SetActive(false);
            live1.SetActive(true);

        }
        // player collides powerups
        if (collision.gameObject.tag == "shield")

        {
            Destroy(collision.gameObject);
            
            
            shield.SetActive(true);

        }
        
        



    }


}
