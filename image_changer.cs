using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class image_changer : MonoBehaviour
{

    public Sprite ready;
    public Sprite steady;
    public Sprite rplus;
    public Sprite gplus;
    public Sprite gminus;
    public Sprite rminus;
    float t;

    void Start()
    {
        
        Invoke("fready", 0.2f);
    }

    void fready()
    {
        gameObject.GetComponent<Image>().sprite = ready;
        Invoke("fsteady", 1);
    }

    void fsteady()
    {
        float t = Random.Range(0f, 4f);
        gameObject.GetComponent<Image>().sprite = steady;
        Invoke("go", t);
    }
    void go()
    {
        int rand = Random.Range(0, 4);
        if (rand == 0)
        {
            gameObject.GetComponent<Image>().sprite = rplus;
            //gameObject.GetComponent<UnityEngine.UI.Image> ().sprite = sprite1;
        }
        else if (rand == 1)
        {
            gameObject.GetComponent<Image>().sprite = gplus;
            // gameObject.GetComponent<UnityEngine.UI.Image> ().sprite = sprite2;
        }
        else if (rand == 2)
        {
            gameObject.GetComponent<Image>().sprite = rminus;
            //gameObject.GetComponent<UnityEngine.UI.Image> ().sprite = sprite3;
        }
        else if (rand == 2)
        {
            gameObject.GetComponent<Image>().sprite = gminus;
            //gameObject.GetComponent<UnityEngine.UI.Image> ().sprite = sprite3;
        }
    }
   
}