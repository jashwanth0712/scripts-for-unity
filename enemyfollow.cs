using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfollow : MonoBehaviour
{
    public float speed;
    public float minstopdistance=0.5f;
    public float maxstopdistance=5f;
    public GameObject player;

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = player.GetComponent<Transform>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) < maxstopdistance && Vector2.Distance(transform.position, target.position) > minstopdistance) 
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        
    }
}
