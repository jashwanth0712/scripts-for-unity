using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rotatingplayer : MonoBehaviour
{
    public float movespeed = 600f;
    float movement = 0f;
    Vector2 m;
    public float screenwidth;
        void Start()
    {
        screenwidth = Screen.width;
        
    }
    void Update()
    {
        if (Input.GetTouch(0).position.x > screenwidth / 2)
        {
            movement = 0.5f;
        }
        if (Input.GetTouch(0).position.x < screenwidth / 2)
        {
            movement = -0.5f;
        }
        //movement=Input.GetAxisRaw("Horizontal");
        /* Touch t = Input.GetTouch(0);
         m = t.rawPosition;
         movement = m.x/100;



         Debug.Log(movement);*/
    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -movespeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(0);  
    }
}

