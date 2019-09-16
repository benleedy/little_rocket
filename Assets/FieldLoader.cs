using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldLoader : MonoBehaviour
{
    [SerializeField] GameObject asteroidPattern;
    // Start is called before the first frame update
    void Start()
    {
        LoadAsteroids();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LoadAsteroids()
    {
        Instantiate(asteroidPattern, transform.position, transform.rotation);
    }
}
