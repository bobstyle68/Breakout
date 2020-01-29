using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    int blocksRemaining = 6;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            blocksRemaining = blocksRemaining - 1;
        }
    }
}
