using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(KeyCode.UpArrow)) 
      {
        rb.velocity = new Vector2(rb.velocity.x, speed);
      }

      else if (Input.GetKey(KeyCode.DownArrow)) 
      {
        rb.velocity = new Vector2(rb.velocity.x, -speed);
      }

      else if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow)) 
      {
        rb.velocity = new Vector2(rb.velocity.x, 0);
      }
    }
}
