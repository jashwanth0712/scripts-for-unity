using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skin2 : MonoBehaviour
{
    Text amount;
    // Start is called before the first frame update
    void Start()
    {
        amount = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("s2") == 1)
        {if (PlayerPrefs.GetInt("csid") == 2)
            {
                amount.text = "selected";
            }
        else
            {
                amount.text = "select";
            }
        }
        else
        {
            amount.text = "600";
        }
        
    }
}
