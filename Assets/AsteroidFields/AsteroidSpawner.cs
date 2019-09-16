using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{

    [SerializeField] GameObject asteroid;

    //public static Vector3 asteroidScale;

    // Start is called before the first frame update
    void Start()
    {
        //asteroidScale = transform.localScale;
        LoadAsteroid();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LoadAsteroid()
    {
        //asteroidScale = transform.localScale;
        var newAsteroid = Instantiate(asteroid, transform.position, transform.rotation);
        newAsteroid.transform.parent = gameObject.transform;
        //var newAsteroid = Instantiate(asteroid, transform.position, transform.rotation);
        //asteroid.transform.localScale = transform.localScale * 5f;
        //print(transform.localScale);
        //newAsteroid.transform.localScale = transform.localScale;
    }
}
