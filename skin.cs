using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skin: MonoBehaviour
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
        if (PlayerPrefs.GetInt("s") == 1)
        {if (PlayerPrefs.GetInt("csid") == 0)
            {
                Debug.Log(PlayerPrefs.GetInt("csid"));
                amount.text = "selected";
            }
        else
            {
                amount.text = "select";
            }
        }
        
    }
}
