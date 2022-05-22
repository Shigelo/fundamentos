using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int level;
    public int health;

    //se declara un constructor
    //El parametro es un script
    public PlayerData (Player player)
    {
        level = player.level;
        health = player.health;
    }

}
