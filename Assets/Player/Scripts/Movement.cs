using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float runSpeed;
    [SerializeField] KeyCode moveForward;
    [SerializeField] KeyCode moveBackward;
    [SerializeField] KeyCode moveLeft;
    [SerializeField] KeyCode moveRight;

    Rigidbody controller;

    //CharacterController controller = this.GetComponent<CharacterController>();

    void Start()
    {
        controller = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveForward))
            this.transform.position += transform.forward * runSpeed * Time.deltaTime;
        if (Input.GetKey(moveBackward))
            this.transform.position -= transform.forward * runSpeed * Time.deltaTime;
        if (Input.GetKey(moveLeft))
            this.transform.position -= transform.right * runSpeed * Time.deltaTime;
        if (Input.GetKey(moveRight))
            this.transform.position += transform.right * runSpeed * Time.deltaTime;
    }
}
