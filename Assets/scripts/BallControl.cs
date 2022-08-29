using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Vector2 pauseVel;
    public int speed = 25;

    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // chooses a random direction (left or right) to start the ball moving
    void GoBall()
    {
        float rand = Random.Range(0,2);
        if(rand < 1)
        {
            rb2d.AddForce(new Vector2(speed, Random.Range(-25,25)));
        }
        else
        {
            rb2d.AddForce(new Vector2(-speed, Random.Range(-25,25)));
        }
    }

    // resets ball position to center
    void ResetBall()
    {
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    // restarts the game
    void RestartGame()
    {
        ResetBall();
        Invoke("GoBall", 1);
    }

    void PauseBall()
    {
        pauseVel = rb2d.velocity;
        rb2d.velocity = Vector2.zero;
    }

    void StartBall()
    {
        rb2d.velocity = pauseVel;
    }

    // what happens when ball collides
    void OnCollisionEnter2d(Collision2D coll)
    {
        if(coll.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.x = rb2d.velocity.x;
            vel.y = (rb2d.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
            rb2d.velocity = vel;
        }
    }
}
