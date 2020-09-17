using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	private Rigidbody2D rb;
	private bool start = false;
	private AudioSource[] sfx;

	void Start() {
		rb = GetComponent<Rigidbody2D>();
		sfx = GetComponents<AudioSource>();
		transform.position = new Vector2(0f,0f);
		Respawn();
	}

	void Respawn() {
		start = false;
		GameObject paddle  = GameObject.Find("paddle");
		transform.position = new Vector2(paddle.transform.position.x, paddle.transform.position.y+4);
	}

	void OnCollisionEnter2D(Collision2D collision) {
		// ball.center.x - paddle.center.x * 10
		if(collision.collider.tag == "paddle" && start) {
			rb.velocity = new Vector2((collision.otherCollider.transform.position.x - collision.collider.transform.position.x) * 8, rb.velocity.y);
			sfx[4].Play(0);
		} else if(collision.collider.tag == "brick") {
			++Score.value;
			Destroy(collision.gameObject);
			sfx[2].Play(0);
		} else if(collision.collider.tag == "wall") {
			sfx[3].Play(0);
		}
	}

	void Update() {
		if(transform.position.y < -105) {
			sfx[0].Play(0);
			Respawn();
		} else if(!start && Input.GetKey(KeyCode.Space)) {
			sfx[1].Play(0);
			rb.velocity = new Vector2(0f,80f);
			start = true;
		} else if(!start) {
			Respawn();
		}
	}
}
