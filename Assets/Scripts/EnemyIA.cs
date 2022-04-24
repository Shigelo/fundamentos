using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIA : MonoBehaviour
{

    public float movementSpeed;
    public bool  flip;
    //public Rigidbody2D rb;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        Flip();
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        Debug.Log("entro a condicion");
        if(collision.gameObject.CompareTag("wall"))
        {
            if(flip)
            {
                flip = false;
            }
            else
            {
                flip = true;
            }
        }
    }

    void Flip()
    {
        if(flip)
        {
            transform.Translate(2*Time.deltaTime * movementSpeed, 0, 0);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * movementSpeed,0,0);
        }
    }
}
