using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

	public float jumpForce = 10f;

	private readonly float destoryDistance = 10f;

	void Update()
	{
		DestoryPlatformsOutOfView();
	}

	private void DestoryPlatformsOutOfView()
	{
		// If the platform is out of view of the camera, destroy it.
		if ((Camera.main.transform.position.y - transform.position.y) > destoryDistance)
		{
			Destroy(gameObject);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{

		if (collision.relativeVelocity.y <= 0f)
		{

			Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
			if (rb != null)
			{
				Vector2 velocity = rb.velocity;
				velocity.y = jumpForce;
				rb.velocity = velocity;

				if (transform.name.Contains("Destroy"))
				{
					Destroy(gameObject);
				}
					
				
			}
		}
	}
}
