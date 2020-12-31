using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partyblast : MonoBehaviour
{
    public float spawnrate = 0.2f;
    public GameObject hexagonPrefab;
    public GameObject crown;
    public GameObject blast;
    private float nexttimetospawn = 0.5f;
    public static int coininscene = 0;
    public static int party ;
    float x, y;
    Vector3 pos;
    int k = 0;
    int h = 0;
    public void Start()
    {
        spawner.coininscene = 0;

    }
    void Update()
    {
        if (party == 1 && h<10)
        {
            if (Time.time >= nexttimetospawn)
            {
                h++;
                if (k == 0)
                {


                    y = Random.Range(-4, 5);
                    x = Random.Range(-8, 8);
                    pos.x = x;
                    pos.y = y;
                    Instantiate(crown, pos, Quaternion.identity);
                    nexttimetospawn = Time.time + 1f / spawnrate;
                    coininscene = 0;
                    k = 1;
                }
                else if (k == 1)
                {
                    y = Random.Range(-4, 5);
                    x = Random.Range(-8, 8);
                    pos.x = x;
                    pos.y = y;
                    Instantiate(crown, pos, Quaternion.identity);
                    nexttimetospawn = Time.time + 1f / spawnrate;
                    coininscene = 0;
                    k = 2;

                }
                else
                {
                    pos.z = 0;

                    y = Random.Range(-4, 5);
                    x = Random.Range(-8, 8);
                    pos.x = x;
                    pos.y = y;
                    Instantiate(hexagonPrefab, pos, Quaternion.identity);
                    nexttimetospawn = Time.time + 1f / spawnrate;
                    coininscene = 0;
                    k = 0;


                }
            }
        }
    }
}

