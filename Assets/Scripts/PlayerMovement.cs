using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public float runSpeed = 30f;
    float horizontalMove  = 0f;


    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;     
    }

    private void FixedUpdate() {
      //  controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
}
