using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotator : MonoBehaviour
{
    float rotationSpeed = 1f;
    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = Random.RandomRange(-20f, 20f);
        //print(rotationSpeed);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, (Time.deltaTime * rotationSpeed), Space.World);
    }
}
