using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieBehavior : MonoBehaviour {

	private float speed;
	private float posY;
	private float posX;

	// Use this for initialization
	void Start () {
		speed = Random.Range(-0.03f, -0.06f);
		posY = Random.Range (-4.0f, 2.0f);
		posX = Random.Range (-8.5f, 0.0f);

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x - speed, posY);
	}
}
