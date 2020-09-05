using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Tracks game progress, score

public class Player : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerScore;
    int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        playerScore.text = score.ToString();
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
        playerScore.text = score.ToString();
    }
}
