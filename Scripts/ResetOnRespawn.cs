using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetOnRespawn : MonoBehaviour {

    private Vector3 startPosition;
    private Quaternion startRotation; // why are we not using a single Transform variable to reference both?
    private Vector3 startLocalScale;

    private Rigidbody2D myRigidbody;

	// Use this for initialization
	void Start () {

        // transform refers to gameObject that the script will be attached to
        // a full way of saying this would be gameObject.transform.position, etc.
        startPosition = transform.position;
        startRotation = transform.rotation;
        startLocalScale = transform.localScale;

        if (GetComponent<Rigidbody2D>() != null)
        {
            myRigidbody = GetComponent<Rigidbody2D>();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ResetObject()
    {
        transform.position = startPosition;
        transform.rotation = startRotation;
        transform.localScale = startLocalScale;

        if (myRigidbody != null)
        {
            myRigidbody.velocity = Vector3.zero; // shorthand way of saying new Vector3(0f, 0f, 0f_
        }
    }
}
