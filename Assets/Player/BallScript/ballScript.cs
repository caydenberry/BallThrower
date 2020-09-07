
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
        //rb_ball.GetComponent<Rigidbody>();

        //this.AddForce(frontForce, ForceMode.Impulse);

        StartCoroutine(DelayRoutine());

        //Destroy(rb_ball);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DelayRoutine()
    {
        yield return new WaitForSeconds(5);
    }
}
