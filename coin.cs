using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coin : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public float distance;
    public GameObject coins;
    public GameObject crownblast;
    public GameObject coinblast;
    public GameObject exp;
    public void Start()
    {
        
            DontDestroyOnLoad(gameObject);
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance);
        
        if (other.CompareTag("coin"))
        {
            scorescript.scorevalue += 1;
            if (scorescript.scorevalue == 10)
            {
                Destroy(other.gameObject);
                
                GameObject coinCollected = (GameObject)Instantiate(crownblast);
                coinCollected.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                Invoke("level2", 0f);
                
            }
            if (scorescript.scorevalue == 20)
            {
                Destroy(other.gameObject);
                
                GameObject coinCollected = (GameObject)Instantiate(crownblast);
                coinCollected.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                Invoke("level3", 0f);

            }
            if (scorescript.scorevalue == 30)
            {
                Destroy(other.gameObject);
            
                GameObject coinCollected = (GameObject)Instantiate(crownblast);
                coinCollected.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                Invoke("level4", 0f);

            }
            if (scorescript.scorevalue == 40)
            {
                Destroy(other.gameObject);

                GameObject coinCollected = (GameObject)Instantiate(crownblast);
                coinCollected.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                SceneManager.LoadScene(5);
            }
            if (scorescript.scorevalue == 50)
            {
                Destroy(other.gameObject);

                GameObject coinCollected = (GameObject)Instantiate(crownblast);
                coinCollected.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                SceneManager.LoadScene(6);
            }
            if (scorescript.scorevalue == 60)
            {
                Destroy(other.gameObject);

                GameObject coinCollected = (GameObject)Instantiate(crownblast);
                coinCollected.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                SceneManager.LoadScene(7);
            }
            if (scorescript.scorevalue == 70)
            {
                Destroy(other.gameObject);

                GameObject coinCollected = (GameObject)Instantiate(crownblast);
                coinCollected.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                SceneManager.LoadScene(8);
            }
            if (scorescript.scorevalue == 80)
            {
                Destroy(other.gameObject);

                GameObject coinCollected = (GameObject)Instantiate(crownblast);
                coinCollected.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                SceneManager.LoadScene(9);
            }
            else
            {
                Destroy(other.gameObject);

                GameObject coinCollected = (GameObject)Instantiate(coinblast);
                coinCollected.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }



        }
       
        

            //GameObject e = Instantiate(explosion) as GameObject;
            // e.transform.position = transform.position;
          //  Destroy(other.gameObject);
        // Destroy(this.gameObject);
       // scorescript.scorevalue += 1;
    }
    public void level2()
    {
        SceneManager.LoadScene(2);
    }
    public void level3()
    {
        SceneManager.LoadScene(3);
    }
    public void level4()
    {
        SceneManager.LoadScene(4);
    }
    public void destroyed()
    {
        SceneManager.LoadScene(0);
    }



}











    // Use this for initialization
    /*  void Start()
      {
          rb = this.GetComponent<Rigidbody2D>();
          rb.velocity = new Vector2(0, speed);
          screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
      }

      // Update is called once per frame
      void Update()
      {
          if (transform.position.y >15)
          {
              Destroy(this.gameObject);
          }
      }*/


