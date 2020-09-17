using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
	private Rigidbody2D rb;
	public float speed = 400;

    void Start() {
      rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
      if(Input.GetKey(KeyCode.LeftArrow))       rb.MovePosition(new Vector2(transform.position.x - speed * Time.deltaTime, 0f));
      else if(Input.GetKey(KeyCode.RightArrow)) rb.MovePosition(new Vector2(transform.position.x + speed * Time.deltaTime, 0f));
    }
}
