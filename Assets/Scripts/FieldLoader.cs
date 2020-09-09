using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FieldLoader : MonoBehaviour
{
    [SerializeField] int seed = 820508;
    [SerializeField] GameObject playerRocket;
    float loadLine = 0f;
    float chunkLoadCenter = 60f;

    //[SerializeField] GameObject landingZone;
    //[SerializeField] GameObject asteroidWalls;
    [SerializeField] int minSize = 5;
    [SerializeField] int maxSize = 40;
    [SerializeField] GameObject asteroid00;
    [SerializeField] GameObject asteroid01;
    [SerializeField] GameObject asteroid02;
    [SerializeField] GameObject asteroid03;
    [SerializeField] GameObject asteroid04;


    GameObject[] asteroids = new GameObject[5];

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Random.InitState(seed);

        asteroids[0] = asteroid00;
        asteroids[1] = asteroid01;
        asteroids[2] = asteroid02;
        asteroids[3] = asteroid03;
        asteroids[4] = asteroid04;
        
        LoadFields();

    }

    // Update is called once per frame
    void Update()
    {
        //when the player lands on a checkpoint, trigger loading the next chunk
        if (playerRocket.transform.position.y > loadLine)
        {
            LoadFields();
        }
        score = FindObjectOfType<Player>().GetScore();
        int playerAltitude = (int)playerRocket.transform.position.y;
        if (score < playerAltitude)
        {
            FindObjectOfType<Player>().IncreaseScore(playerAltitude - score);
        }
    }

    void LoadFields()
    {
            for (int i = 0; i < 4; i++)
                {
                    LoadAsteroids();
                    chunkLoadCenter += 100f;
                    transform.position = new Vector3(0f, chunkLoadCenter, 0f);
                }

            loadLine += 400f;
    }

    void LoadAsteroids()
    {
        //Instantiate(asteroidWalls, transform.position, transform.rotation);

        Vector2Int center = new Vector2Int((int) transform.position.x, (int) transform.position.y);

        for (int i = 0; i < 100; i++)
        {
            int randomAsteroid = Random.Range(0, asteroids.Length);
            int size = Random.Range(minSize, maxSize);
            Vector2Int location = center + new Vector2Int(Random.Range(-95, 95), Random.Range(-100, 100));
            if (Physics.OverlapSphere(new Vector3Int(location.x, location.y, 0), 10f + size).Length == 0)
            {
                var newAsteroid = Instantiate(asteroids[randomAsteroid], new Vector3Int(location.x, location.y, 0), Quaternion.Euler(0, 0, 0));
                newAsteroid.transform.localScale = new Vector3(size, size, size);
            }
        }
    }
}
