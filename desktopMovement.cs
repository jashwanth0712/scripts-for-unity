using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desktopMovement : MonoBehaviour
{
    public Transform player;
    public float speed = 5.0f;
    public GameObject bulletPrefab;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        moveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        if (Input.touchCount>0 )
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                shootBullet();
            }
           
         }
        else if (Input.GetKeyDown("space"))
        {
            shootBullet();
        }
    }

    void moveCharacter(Vector2 direction)
    {
        player.Translate(direction * speed * Time.deltaTime);
    }
    public void shootBullet()
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = player.transform.position +offset;
        


    }
}