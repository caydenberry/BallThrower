using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace master
{
    public class Goalpost_Script : MonoBehaviour
    {
        [SerializeField] GameObject ball;
        [SerializeField] Texture green;
        [SerializeField] GameObject master;
        masterScript ms;
        Renderer scoreRen;
        bool isScored;
        // Start is called before the first frame update
        void Start()
        {
            isScored = false;
            scoreRen = GetComponent<Renderer>();
            ms = master.GetComponent<masterScript>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider ball)
        {
            if (isScored == false)
            {
                //score + 1 on HUD
                scoreRen.material.SetTexture("_MainTex", green);
                isScored = true;
                Debug.Log("Score");
                ms.incrementScore();
            }
        }
    }
}
