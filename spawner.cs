using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float spawnrate = 1f;
    public GameObject hexagonPrefab;
    private float nexttimetospawn = 2f;
    
    void Update()
    {
        if (Time.time >= nexttimetospawn)
        {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nexttimetospawn = Time.time + 1f / spawnrate;
        }
    }
}
