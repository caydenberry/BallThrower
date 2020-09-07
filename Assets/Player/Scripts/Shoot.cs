using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] KeyCode shootKey;
    [SerializeField] GameObject ball;
    bool isShooting = false;
    Vector3 shotOrigin;
    Quaternion shotRotation;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        shotOrigin = this.transform.position;
        shotRotation = this.transform.rotation;

        if (Input.GetKeyDown(shootKey) && isShooting == false)
        {
            isShooting = true;
            Instantiate(ball, shotOrigin, shotRotation);
            Debug.Log("SHOOT YOUR SHOT");
        }
        else
            isShooting = false;
    }
}
