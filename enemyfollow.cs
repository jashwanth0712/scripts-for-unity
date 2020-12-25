








/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class enemyfollow : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    public GameObject exp;
    public float rotationspeed;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationspeed * Time.deltaTime);
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
       // rb.rotation = angle;
        direction.Normalize();
        movement = direction;
        
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("blue"))
        {
            scorescript.scorevalue = 0;
            Destroy(other.gameObject);

            GameObject explosion = (GameObject)Instantiate(exp);
            explosion.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);


            Invoke("destroyed", 2);
        }
    }
    public void destroyed()
    {
        SceneManager.LoadScene(0);
    }
}







*/










using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyfollow : MonoBehaviour
{
    public float speed;
    public float minstopdistance = 0.5f;
    public float maxstopdistance = 5f;
   
    public GameObject exp;
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("blue").GetComponent<Transform>();


    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * 200 * Time.deltaTime);
        if (Vector2.Distance(transform.position, target.position) < maxstopdistance && Vector2.Distance(transform.position, target.position) > minstopdistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("blue"))
        {
            Destroy(GameObject.FindGameObjectWithTag("circle"));
            Destroy(GameObject.FindGameObjectWithTag("outercircle"));
            if (highscore.hscore < scorescript.scorevalue)
            {
                highscore.hscore = scorescript.scorevalue;
            }
            scorescript.scorevalue = 0;
            Destroy(other.gameObject);

            GameObject explosion = (GameObject)Instantiate(exp);
            explosion.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
          

            Invoke("destroyed", 2);
        }
    }
    public void destroyed()
    {
        SceneManager.LoadScene(0);
    }
}

