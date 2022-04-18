using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public float movementSpeed = 1f;
    public float jumpForce = 1f;
    float horizontalMovement;

    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontalMovement, 0,0) * Time.deltaTime * movementSpeed;
    
        if(Input.GetButtonDown("Jump") && Mathf.Abs(rigidBody.velocity.y) < 0.1f)
        {
            rigidBody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}

