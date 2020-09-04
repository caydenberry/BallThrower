using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouselook : MonoBehaviour
{
    [SerializeField] string MouseX;
    [SerializeField] string MouseY;
    [SerializeField] float MouseSensitivity = 1.0f;
    [SerializeField] Rigidbody controller;

    private float minimumY = 180.0f;
    private float maximumY = -180.0f;
    private float axisChange = 1.0f;

    private Vector3 currentEulerAngle;
    private Quaternion currentRotation;
    private Quaternion playerRotation;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Checks to see if player is looking directly up or down and locks the axis if they are trying to look up or down too far
        if (currentEulerAngle[0] >= 90 && Input.GetAxis(MouseY) < 0 || currentEulerAngle[0] <= -90 && Input.GetAxis(MouseY) > 0)
            axisChange = 0.0f;
        else
            axisChange = 1.0f;

        //Sets eulerangle (angle of camera)
        currentEulerAngle.Set(currentEulerAngle[0] - (Input.GetAxis(MouseY) * MouseSensitivity) * axisChange, currentEulerAngle[1] + Input.GetAxis(MouseX) * MouseSensitivity, currentEulerAngle[2]);

        //sets up player rotation angles
        playerRotation.eulerAngles = currentEulerAngle;

        //Caps camera rotation (couldn't figure out Vector3.ClampMagnitude)
        if (currentEulerAngle[0] > 90)
            currentEulerAngle[0] = 90;
        else if (currentEulerAngle[0] < -90)
            currentEulerAngle[0] = -90;

        //sets camera rotation
        currentRotation.eulerAngles = currentEulerAngle;
        transform.rotation = currentRotation;

        //sets up rotation of the player
        playerRotation.z = 0; playerRotation.x = 0;
        controller.transform.rotation = playerRotation;
    }

    private void FixedUpdate()
    {
        
    }
}
