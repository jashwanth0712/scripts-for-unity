using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

	Rigidbody2D rb;
	float dirX,dirY, moveSpeed = 5f;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		dirX = Input.GetAxisRaw("Horizontal") * moveSpeed;
		dirY = Input.GetAxisRaw("Vertical") * moveSpeed;
		if (Input.GetButtonDown("Jump") && rb.velocity.y == 0)
			rb.AddForce(Vector2.up * 400f);
	}

	void FixedUpdate()
	{
		rb.velocity = new Vector2(dirX, dirY);

	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name.Equals("Cloud"))
			this.transform.parent = col.transform;
	}

	void OnCollisionExit2D(Collision2D col)
	{
		if (col.gameObject.name.Equals("Cloud"))
			this.transform.parent = null;
	}
}