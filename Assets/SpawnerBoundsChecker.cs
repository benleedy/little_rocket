using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBoundsChecker : MonoBehaviour
{
    [SerializeField] GameObject asteroidSpawner;
    int collisions = 0;
    float asteroidScale = 5f;
    private void OnTriggerEnter(Collider other)
    {
        collisions = collisions + 1;
    }

    private void OnTriggerExit(Collider other)
    {
        collisions = collisions - 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(collisions == 0)
        {
            print("Not colliding right now.");
        }
        */
        
        if (collisions == 0)
        {
            /*
            Instantiate(asteroidSpawner, transform.position, transform.rotation);
            */
            var newAsteroid = Instantiate(asteroidSpawner, transform.position, transform.rotation);
            newAsteroid.transform.localScale = new Vector3(asteroidScale, asteroidScale, asteroidScale);
            //newAsteroid.transform.parent = gameObject.transform;

            asteroidScale = Random.RandomRange(5f, 30f);
            transform.localScale = new Vector3(asteroidScale, asteroidScale, asteroidScale);
        }
    }
}
