using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour {

	public float speed = 30;

	// public GameObject theBullet;

	void FixedUpdate(){
		float horzMove = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (horzMove, 0) * speed;
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			// Fire bullet
			// Fire bullet sound
		}
	}
}
