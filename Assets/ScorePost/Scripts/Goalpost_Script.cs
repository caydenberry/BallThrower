using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace master
{
    public class Goalpost_Script : MonoBehaviour
    {
        [SerializeField] GameObject ball;
        [SerializeField] Material green;
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
                scoreRen.material = green;
                isScored = true;
                ms.incrementScore();
            }
        }
    }
}
