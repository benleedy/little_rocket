﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkLoader : MonoBehaviour
{
    [SerializeField] GameObject playerRocket;
    float loadLine = 60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LoadChunk()
    {
        GameObject firstChunk = Resources.Load<GameObject>("Chunks/Asteroids001.prefab");
        firstChunk.transform.position = new Vector3(0f, 60f, 0f);
    }
}
