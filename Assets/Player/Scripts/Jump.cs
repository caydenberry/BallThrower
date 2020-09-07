using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] KeyCode jump;
    Rigidbody controller;
    Vector3 jumpForce;
    bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<Rigidbody>();
        //controller.isKinematic = true;
        controller.useGravity = true;
        jumpForce.Set(0,5.0f,0);
    }

    // Update is called once per frame
    void Update()
    {
    }

    //FixedUdate for physics based items
    void FixedUpdate()
    {
        if (Input.GetKeyDown(jump) && isJumping == false/*&& controller.isGrounded == false*/)
        {
            controller.useGravity = true;
            controller.AddForce(jumpForce, ForceMode.Impulse);
            isJumping = true;
        }
        else
            isJumping = false;
    }

    void PlayerJump()
    {

    }
}
