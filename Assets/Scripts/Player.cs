using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Tracks game progress, score

public class Player : MonoBehaviour
{
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetScore()
    {
        return score;
    }

    public void IncreaseScore(int points)
    {
        score += points;
        Debug.Log("Current points: " + points);
    }
}
