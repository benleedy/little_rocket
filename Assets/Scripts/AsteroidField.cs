using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidField : MonoBehaviour
{
    [SerializeField] GameObject asteroid;
    [SerializeField] GameObject asteroidField;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(asteroid, new Vector3(0, 10, 0), Quaternion.Euler(0,0,0), asteroidField.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
