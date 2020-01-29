using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float MovementSpeed = 10;
    float horizontal;
    Rigidbody2D body;
    Vector3 nextPosition;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        horizontal = Input.GetAxis("Horizontal");
        nextPosition.x = horizontal * MovementSpeed * Time.deltaTime;

    }
    private void FixedUpdate()
    {
        body.velocity = nextPosition;
    }

}
