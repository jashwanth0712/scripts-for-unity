using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class money : MonoBehaviour
{
    public static int scorevalue;
    public static int hscore;
    public static int walet;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
       walet = PlayerPrefs.GetInt("walet");
       walet = scorescript.paisa/2 + walet;
        //walet = 0;
     

    }

    // Update is called once per frame
    void Update()
    {
        score.text = " " + walet;
        PlayerPrefs.SetInt("walet", walet);
        scorescript.paisa = 0;
        //score.text = "" + highscore.hscore + "";

        // score.text = " "+walet;
        //PlayerPrefs.SetInt("walet", walet);
    }
}
