﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    private LevelManager theLevelManager;

    public int coinValue;

	// Use this for initialization
	void Start () {
        theLevelManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            theLevelManager.AddCoins(coinValue);

            //Destroy(gameObject);

            gameObject.SetActive(false);
        }
    }

}
