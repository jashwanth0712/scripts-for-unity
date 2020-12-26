using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyroscope : MonoBehaviour
{
	public int level;
	public int health;
	public int score;
	public int hscore;
	Rigidbody2D rb;
	float dirX;
	float moveSpeed = 20f;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();

	}

	// Update is called once per frame
	void Update()
	{
		dirX = Input.acceleration.x * moveSpeed;
		transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), Mathf.Clamp(transform.position.y, -4.7f, 4.7f));
	}

	void FixedUpdate()
	{
		rb.velocity = new Vector2(dirX, 0f);
	}
	public void saveplayer()
    {
		savesystem.saveplayer(this);
    }
	public void loadplayer()
    {
		playerdata data = savesystem.loadplayer();
		level = data.level;
		health = data.health;
		score = data.score;
		hscore = data.hscore;
    }
	
}
