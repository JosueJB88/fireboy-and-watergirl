using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // public CharacterController2D controller;
    public float runSpeed = 1500f;
    float horizontalMove = 0f;
    bool jump = false;
    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        // Debug.Log(horizontalMove);
        if(Input.GetButtonDown("Jump")){
            Debug.Log("jump");
            jump = true;
        }
    }

    void FixedUpdate()
    {
        gameObject.GetComponent<CharacterController2D>().Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump=true;
    }
}
