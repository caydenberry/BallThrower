
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 frontForce;
    Rigidbody rb_ball;


    void Start()
    {
        frontForce = this.transform.forward;

        frontForce.Set(frontForce[0] * 10,frontForce[1] * 10,frontForce[2] * 10);
        //Get self rigidbody
        rb_ball = this.GetComponent<Rigidbody>();

        //add force to rigidbody
        rb_ball.AddForce(frontForce, ForceMode.Impulse);

        //destroy the self
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
