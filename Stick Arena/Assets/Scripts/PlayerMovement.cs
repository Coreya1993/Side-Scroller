using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //public Animator animator;
    public CharacterController2D controller;


    float horizontalMove = 0f;
    public float runSpeed = 60f;


    bool jump = false;
    bool crouch = false;

    // Use this for initialization

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;


        if (Input.GetKeyDown("space"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
    }


    //Move the character
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);

        jump = false;
        crouch = false;
    }
}
