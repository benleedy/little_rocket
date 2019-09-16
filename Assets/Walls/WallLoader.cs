using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLoader : MonoBehaviour
{
    [SerializeField] GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        LoadWall();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LoadWall()
    {
        Instantiate(wall, transform.position, transform.rotation);
    }
}
