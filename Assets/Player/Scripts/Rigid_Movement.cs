using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigid_Movement : MonoBehaviour
{
    Rigidbody rigidplayer;
    [SerializeField] float runSpeed;
    [SerializeField] KeyCode moveForward;
    [SerializeField] KeyCode moveBackward;
    [SerializeField] KeyCode moveLeft;
    [SerializeField] KeyCode moveRight;
    Vector3 playerDirection;

    // Start is called before the first frame update
    void Start()
    {
        rigidplayer = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        playerDirection = transform.forward;
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(moveForward))
            rigidplayer.AddForce(playerDirection, ForceMode.Force);
        else
            rigidplayer.AddForce(playerDirection, 0);
        if (Input.GetKey(moveBackward)) { }
        //this.transform.position -= transform.forward * runSpeed * Time.deltaTime;
        if (Input.GetKey(moveLeft)) { }
        //this.transform.position -= transform.right * runSpeed * Time.deltaTime
        if (Input.GetKey(moveRight)) { }
        //this.transform.position += transform.right * runSpeed * Time.deltaTime;
    }
}
