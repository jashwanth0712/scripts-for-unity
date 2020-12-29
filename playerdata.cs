using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class playerdata
{
    public int level;
    public int health;
    public int score;
    public int hscore;
    public playerdata(gyroscope player)
    {
        level = player.level;
        health = player.health;
        score = player.score;
        hscore = player.hscore;
        
    }

}
