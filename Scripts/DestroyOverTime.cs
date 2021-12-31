using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOverTime : MonoBehaviour {

    public float lifeTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        lifeTime = lifeTime - Time.deltaTime; // Time.deltaTime = amount of time it takes for a particular frame to take place, update loop
        if(lifeTime <= 0f)
        {
            Destroy(gameObject);
        }
	}
}
