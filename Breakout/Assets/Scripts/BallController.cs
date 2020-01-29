using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float MovementSpeed = 10;
    float currentSpeed;
    Vector3 startPosition;
    Vector2 direction;
    Rigidbody2D body;

    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        currentSpeed = MovementSpeed;
        ResetPosition();
        PickRandomDirection(40,130);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ResetPosition()
    {
        body.MovePosition(Vector2.zero);
    }
    void PickRandomDirection(float min, float max)
    {
        direction.x = Random.Range(min, max);
        direction.y = Random.Range(min, max);
        direction.Normalize();
        //if even number move right
        if (Random.Range(11, 100) % 2 == 0)
        {
            currentSpeed = -MovementSpeed;
        }
        //if odd number move left
        else
        {
            currentSpeed = MovementSpeed;
        }

        body.velocity = direction * MovementSpeed;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Kill")
        {

        }
    }
}
