using System.Collections;
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
        loadLine++;
        print(loadLine);
        if (playerRocket.transform.position.y > loadLine)
        {
            LoadChunk();
        }
    }

    void LoadChunk()
    {
        loadLine++;
    }
}
