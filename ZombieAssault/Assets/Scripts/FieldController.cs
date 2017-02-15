using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldController : MonoBehaviour {

	public AudioSource ZombieDyingScream;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Zombie")) {
			//in actual game the character will get hurt, zombie will not get destroyed.
			ZombieDyingScream.Play();
			Destroy (other.gameObject);

		}
}
}
