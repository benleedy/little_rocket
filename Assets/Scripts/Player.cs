using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Tracks game progress, score

public class Player : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerScore;
    [SerializeField] TextMeshProUGUI playerSpeed;
    int score = 0;
    float speed = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        playerScore.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        speed = gameObject.GetComponent<Rigidbody>().velocity.magnitude;
        playerSpeed.text = "Speed: " + speed.ToString("0.0") + "m/s";
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

    public float GetPlayerVelocity()
    {
        return speed;
    }
}
