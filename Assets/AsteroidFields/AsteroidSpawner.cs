using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] GameObject asteroid;
    // Start is called before the first frame update
    void Start()
    {
        LoadAsteroid();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LoadAsteroid()
    {
        Instantiate(asteroid, transform.position, transform.rotation);
        //var newAsteroid = Instantiate(asteroid, transform.position, transform.rotation);
        //asteroid.transform.localScale = transform.localScale * 5f;
        //print(transform.localScale);
        //newAsteroid.transform.localScale = transform.localScale;
    }
}
