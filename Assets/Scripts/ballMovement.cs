using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement: MonoBehaviour 
{
  private Rigidbody2D rb;
  public float speed;
  public float verticalSpeed;
  private System.Random random;
  public gameInfo logic;
  public float displacement; // to stop the ball from constantly colliding with the player
  // Start is called before the first frame update
  void Start() 
  {
    random = new System.Random();
    rb = GetComponent <Rigidbody2D> ();
    int horizontal = Random.Range(0, 2) == 0 ? -1 : 1;
    float vertical = Random.Range(0, 2) > 1 ? Random.Range(-1f, -0.5f) : Random.Range(1f, 0.5f);
    rb.velocity = new Vector2(speed * horizontal, verticalSpeed * vertical);
  }

  // Update is called once per frame
  void Update() 
  {

  }

  private void OnCollisionEnter2D(Collision2D collision) 
  {
    switch (collision.gameObject.tag) 
    {
    case "Player":
      if (transform.position.x < 0)
      {
        transform.position = new Vector3(transform.position.x + displacement, transform.position.y);
      }

      else if (transform.position.x > 0)
      {
        transform.position = new Vector3(transform.position.x - displacement, transform.position.y);
      }
      rb.velocity = new Vector2(rb.velocity.x * -1, rb.velocity.y);
      break;

    case "Wall":
      rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * -1);
      break;

    case "Out1":
      logic.addPlayer2Score();
      ResetBall();
      float vertical = Random.Range(0, 2) > 1 ? Random.Range(-1f, -0.5f) : Random.Range(1f, 0.5f);
      rb.velocity = new Vector2(-speed, verticalSpeed * vertical);
      break;

    case "Out2":
      logic.addPlayer1Score();
      ResetBall();
      vertical = Random.Range(0, 2) > 1 ? Random.Range(-1f, -0.5f) : Random.Range(1f, 0.5f);
      rb.velocity = new Vector2(speed, verticalSpeed * vertical);
      break;
    }
  }

  public void ResetBall()
  {
    rb.velocity = Vector2.zero; 
    rb.position = Vector2.zero; 
  }
}