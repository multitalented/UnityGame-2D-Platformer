﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenWiggleController : MonoBehaviour {

    public Transform leftPoint;
    public Transform rightPoint;

    public float moveSpeed;

    private Rigidbody2D myRigidbody;

    public bool movingRight;

	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
        if (movingRight && transform.position.x > rightPoint.position.x)
        {
            movingRight = false;
            //myRigidbody.transform.velocity
        }
        if (!movingRight && transform.position.x < leftPoint.position.x)
        {
            movingRight = true;
        }
        if (movingRight)
        {
            myRigidbody.velocity = new Vector3(moveSpeed, myRigidbody.velocity.y, 0f);
        }
        else
        {
            myRigidbody.velocity = new Vector3(-moveSpeed, myRigidbody.velocity.y, 0f);
        }

	}

    private void OnTriggerEnter2D(Collider2D other) // added by Deanna/myself, in case of instances that green wiggle might fall off (player pushing)
    {
        if (other.tag == "KillPlane")
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
}
