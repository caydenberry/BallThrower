using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masterScript : MonoBehaviour
{
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        while(score <= 3)
        {}
        Debug.Log("You win!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void incrementScore()
    {
        score++;
    }
}
