using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody2D rb;
	public float movespeed = 5f;
	private Vector2 movement;

	// Update is called once per frame
	void Update()
	{
		//Input
		movement.x =Input.GetAxisRaw("Horizontal");
		movement.y = Input.GetAxisRaw("Vertical");
	}

	private void FixedUpdate()
	{
		rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
	}
}
