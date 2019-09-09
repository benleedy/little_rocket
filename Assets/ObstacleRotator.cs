﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotator : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, (Time.deltaTime * rotationSpeed), Space.World);
    }
}
