using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{
    public static int currentskinid=0;  // id for different skins
    
    int s1=0;
    int s = 0;
    int s2=0;//cyan circle with blue border
    

    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("csid"));
        currentskinid = PlayerPrefs.GetInt("csid"); 
        s1= PlayerPrefs.GetInt("s1");
        s = PlayerPrefs.GetInt("s");
        s2 = PlayerPrefs.GetInt("s2");
        // total stored data till now are hscore,walet,csid,s1
    }



    public void skin1()//cyan circle with blue border
    {if (s1 == 0)
        {
            Debug.Log(PlayerPrefs.GetInt("csid"));
            if (money.walet >= 500)
            {
                money.walet = money.walet - 500;
                s1 = 1;
                currentskinid = 1;
                PlayerPrefs.SetInt("csid",currentskinid);
                PlayerPrefs.SetInt("s1",s1);
                Debug.Log(s1);

            }
            else { }
        }
    else {
            currentskinid = 1;
            PlayerPrefs.SetInt("csid", currentskinid);

        }
    
    
    }
    public void starter()//cyan circle with blue border
    {
        Debug.Log(PlayerPrefs.GetInt("csid"));
        if (s == 0)
        {
                s = 1;
                currentskinid = 0;
                PlayerPrefs.SetInt("csid", currentskinid);
                PlayerPrefs.SetInt("s", s1);
                Debug.Log(s);

    
        }
        else
        {
            currentskinid = 0;
            PlayerPrefs.SetInt("csid", currentskinid);

        }
    }


    public void skin2()//cyan circle with blue border
    {
        if (s2 == 0)
        {
            Debug.Log(PlayerPrefs.GetInt("csid"));
            if (money.walet >= 600)
            {
                money.walet = money.walet - 600;
                s2 = 1;
                currentskinid = 2;
                PlayerPrefs.SetInt("csid", currentskinid);
                PlayerPrefs.SetInt("s2", s2);
                Debug.Log(" s2 is selected ");

            }
            else { }
        }
        else
        {
            currentskinid = 2;
            PlayerPrefs.SetInt("csid", currentskinid);

        }


    }
}
