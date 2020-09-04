using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swapCameras : MonoBehaviour
{
    //Just switches the Cameras for debugging, and also as a feature. Why not, right?
    [SerializeField] Camera FPCamera;
    [SerializeField] Camera TPCamera;
    [SerializeField] KeyCode switchCam;

    // Start is called before the first frame update
    void Start()
    {
        FPCamera.enabled = true;
        TPCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(switchCam))
        {
            if(FPCamera.enabled == true)
            {
                FPCamera.enabled = false;
                TPCamera.enabled = true;
            }
            else
            {
                FPCamera.enabled = true;
                TPCamera.enabled = false;
            }
        }
    }
}
