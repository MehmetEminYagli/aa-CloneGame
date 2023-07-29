using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private bool isShot = false;
    private BallManager ballManager;
 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ballManager = FindAnyObjectByType<BallManager>();
    }
    void Update()
    {
        shoot();
    }

    private void shoot()
    {
        if(Input.GetMouseButtonDown(0))
        {
            isShot = true;

            if (isShot)
            {
                rb.AddForce(Vector2.up * speed);
               
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Circle"))
        {
            isShot = false;
            rb.bodyType = RigidbodyType2D.Kinematic;
            transform.SetParent(collision.gameObject.transform);
            ballManager.ActiveBall();
        }

        if (collision.gameObject.CompareTag("Ball"))
        {
            SceneManager.LoadScene(0);
        }
    }

    

}
