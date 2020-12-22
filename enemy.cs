using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    public float rotationspeed;
    public float distance;
    public LineRenderer laser;
    public Gradient redColor;
    public Gradient greenColor;
    public Rigidbody2D rb;
    public float startrot;
    float k;
   
    
    public GameObject exp;
    public GameObject blue;



    // Start is called before the first frame update
    void Start()
    {
       
        Physics2D.queriesStartInColliders = false;
        rb.rotation = startrot+Random.Range(0f, 360f);
    }

    // Update is called once per frame
    void Update()
    {
        k = Random.Range(0f, 2f);
        if (k == 0) 
        {
            transform.Rotate(Vector3.forward * rotationspeed * Time.deltaTime);
            RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance);
            if (hitInfo.collider != null)
            {
                Debug.DrawLine(transform.position, hitInfo.point, Color.red);
                laser.SetPosition(1, hitInfo.point);
                laser.colorGradient = redColor;





                if (hitInfo.collider.CompareTag("blue"))
                {
                   Destroy( GameObject.FindGameObjectWithTag("circle"));
                    Destroy(GameObject.FindGameObjectWithTag("outercircle"));
                    if (highscore.hscore < scorescript.scorevalue)
                    {
                        highscore.hscore = scorescript.scorevalue;
                    }
                    scorescript.scorevalue = 0;
                    Destroy(blue);
                  
                    GameObject explosion = (GameObject)Instantiate(exp);
                    explosion.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                    Invoke("destroyed", 2);
                }
            }
            else
            {
                Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
                laser.SetPosition(1, transform.position + transform.right * distance);
                laser.colorGradient = greenColor;
            }

            laser.SetPosition(0, transform.position);
        }
        else
        {
            transform.Rotate(Vector3.forward * -rotationspeed * Time.deltaTime);
            RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance);
            if (hitInfo.collider != null)
            {
                Debug.DrawLine(transform.position, hitInfo.point, Color.red);
                laser.SetPosition(1, hitInfo.point);
                laser.colorGradient = redColor;

                if (hitInfo.collider.CompareTag("boundary"))
                {
                    Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
                    laser.SetPosition(1, transform.position + transform.right * distance);
                    laser.colorGradient = greenColor;
                }



                    if (hitInfo.collider.CompareTag("blue"))
                {
                    Destroy(GameObject.FindGameObjectWithTag("circle"));
                    Destroy(GameObject.FindGameObjectWithTag("outercircle"));
                    if(highscore.hscore < scorescript.scorevalue)
                    {
                        highscore.hscore = scorescript.scorevalue;
                    }
                    
                    scorescript.scorevalue = 0;

                    Destroy(hitInfo.collider.gameObject);
                    GameObject explosion = (GameObject)Instantiate(exp);
                    explosion.transform.position = new Vector3(hitInfo.collider.gameObject.transform.position.x, hitInfo.collider.gameObject.transform.position.y, hitInfo.collider.gameObject.transform.position.z);
                    Invoke("destroyed", 2);
                }
            }
            else
            {
                Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
                laser.SetPosition(1, transform.position + transform.right * distance);
                laser.colorGradient = greenColor;
            }

            laser.SetPosition(0, transform.position);
        }
       }
    public void destroyed()
    {
       
        SceneManager.LoadScene(0);
    }
   
}
