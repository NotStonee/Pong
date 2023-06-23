using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai : MonoBehaviour
{
  private Rigidbody2D rb;
  public float speed;
  public Rigidbody2D ball;
  public bool computer = true;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();   
    }

    void FixedUpdate()
    {
      if (ball.velocity.x > 0) 
      {
        if (ball.position.y > transform.position.y) 
        {
          rb.velocity = new Vector2(rb.velocity.x, speed);
        }

        else if (ball.position.y < transform.position.y)
        {
          rb.velocity = new Vector2(rb.velocity.x , -speed);
        }
      }
    }
}
