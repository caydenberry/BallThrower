using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace master
{
    public class masterScript : MonoBehaviour
    {
        int score;
        bool isWin;
        // Start is called before the first frame update
        void Start()
        {
            score = 0;
        }

        private void Update()
        {
            if(score == 4 && isWin == false)
            {
                Debug.Log("You Win!");
                isWin = true;
            }
        }

        public void incrementScore()
        {
            score++;
            Debug.Log("Score is " + score);
        }
    }
}
