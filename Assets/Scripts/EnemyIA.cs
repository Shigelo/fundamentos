using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        //Debug.Log("Se entro a Flip");
    }

    private void OnCollisionEnter2D(Collision2D other)  
    {
        Debug.Log("entro a condicion");
        if(other.gameObject.CompareTag("wall"))
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
        else if(other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void Flip()
    {
        if(flip)
        {
            transform.Translate(2 * Time.deltaTime * movementSpeed, 0, 0);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * movementSpeed, 0, 0);
        }
    }
}
