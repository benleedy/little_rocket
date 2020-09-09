using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ObstacleRotator : MonoBehaviour
{
    float rotationSpeed;
    int direction;


    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = Random.Range(5f, 20f);
        direction = Random.Range(1, 3);
        //print(rotationSpeed);

    }

    // Update is called once per frame
    void Update()
    {
        if (direction == 1)
        {
            transform.Rotate(0f, 0f, (Time.deltaTime * rotationSpeed), Space.World);
        }
        else if (direction == 2)
        {
            transform.Rotate(0f, 0f, (Time.deltaTime * -rotationSpeed), Space.World);
        }
        else
        {
            transform.Rotate(0f, 0f, (Time.deltaTime * rotationSpeed), Space.World);
        }
    }
}
