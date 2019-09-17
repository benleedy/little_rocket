using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldLoader : MonoBehaviour
{
    [SerializeField] GameObject playerRocket;
    float loadLine = 0f;
    float chunkLoadCenter = 60f;

    [SerializeField] GameObject landingZone;
    [SerializeField] GameObject asteroidPattern00;
    [SerializeField] GameObject asteroidPattern01;
    [SerializeField] GameObject asteroidPattern02;
    [SerializeField] GameObject asteroidPattern03;
    [SerializeField] GameObject asteroidPattern04;
    [SerializeField] GameObject asteroidPattern05;
    [SerializeField] GameObject asteroidPattern06;
    [SerializeField] GameObject asteroidPattern07;
    [SerializeField] GameObject asteroidPattern08;
    [SerializeField] GameObject asteroidPattern09;

    GameObject[] fields = new GameObject[10];

    // Start is called before the first frame update
    void Start()
    {
        fields[0] = asteroidPattern00;
        fields[1] = asteroidPattern01;
        fields[2] = asteroidPattern02;
        fields[3] = asteroidPattern03;
        fields[4] = asteroidPattern04;
        fields[5] = asteroidPattern05;
        fields[6] = asteroidPattern06;
        fields[7] = asteroidPattern07;
        fields[8] = asteroidPattern08;
        fields[9] = asteroidPattern09;

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
    }

    void LoadFields()
    {

            for (int i = 0; i < 4; i++)
                {
                    if (i == 2)
                    {
                        Instantiate(landingZone, transform.position, transform.rotation);
                        chunkLoadCenter += 60f;
                    transform.position = new Vector3(0f, chunkLoadCenter, 0f);
                    }
                    else
                    {

                    LoadAsteroids(i);
                        chunkLoadCenter += 60f;
                    transform.position = new Vector3(0f, chunkLoadCenter, 0f);
                }
                }

            loadLine += 180f;
    }

    void LoadAsteroids(int pattern)
    {
        Instantiate(fields[pattern], transform.position, transform.rotation);
    }
}
