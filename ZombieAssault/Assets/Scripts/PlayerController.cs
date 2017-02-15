using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D player;
	public int speed;
	public AudioSource PlayerHurt;
	private CapsuleCollider2D playerCollider;
	private string spriteDirection;
	SpriteRenderer sprRend;
	public Sprite sprIdle;
	public Sprite sprProj;
	public Transform firePoint;
	public GameObject chainsaw;

	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody2D> ();
		playerCollider = GetComponent<CapsuleCollider2D> ();
		sprRend = GetComponent<SpriteRenderer> ();
		spriteDirection = "left";
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 move = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0.0f);
		transform.position += move * speed * Time.deltaTime;

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			spriteDirection = "left";
			sprRend.flipX = false;
		} 
		else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			spriteDirection = "right";
			sprRend.flipX = true;
			
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (chainsaw, firePoint.position, firePoint.rotation);
		}
			
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Zombie")) {
			//in actual game the character will get hurt, zombie will not get destroyed.
			PlayerHurt.Play();
			Destroy (other.gameObject);
		}

		if (other.gameObject.CompareTag ("chainsaw")) {
			sprRend.sprite = sprProj;
		}
			
	}


}
