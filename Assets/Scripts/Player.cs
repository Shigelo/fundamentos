using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject prefabMan;
    public GameObject prefabWoman;
    //public string name = "Juan";
    //public int age = 15;
    public bool genre = false;
    //genre = true -> circulo
    public int level = 3;
    public int health = 40;


    private void Start() {

        if(genre == true)
        {
            Instantiate(prefabMan, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else
        {
            Instantiate(prefabWoman, new Vector3(0,0,0), Quaternion.identity);
        }
        
    }
   
}
