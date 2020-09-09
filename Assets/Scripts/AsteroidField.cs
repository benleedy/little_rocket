using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using Random = UnityEngine.Random;

public class AsteroidField : MonoBehaviour
{
    [SerializeField] GameObject asteroid;
    [SerializeField] GameObject marker;
    [SerializeField] GameObject asteroidField;
    Dictionary<Vector2Int, int> asteroidFieldGrid = new Dictionary<Vector2Int, int>();
    //0 = unoccupied
    //1 = buffer area
    //2 = asteroid center
    
// Start is called before the first frame update
void Start()
    {
        //Instantiate(asteroid, new Vector3(0, 10, 0), Quaternion.Euler(0,0,0), asteroidField.transform);
        //Instantiate(asteroid, new Vector3(10, 7, 0), Quaternion.Euler(0, 0, 0), asteroidField.transform);
        //var newAsteroid = Instantiate(asteroid, new Vector3(-5, -3, 0), Quaternion.Euler(0, 0, 0), asteroidField.transform);
        //newAsteroid.transform.localScale = new Vector3(2f, 2f, 2f);
        PopulateField();
        //for (int x = -1; x <= 1; x++)
        //{
        //    for (int y = -1; y <= 1; y++)
        //    {
        //        Debug.Log("Buffer test: " + x.ToString() + "," + y.ToString());
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PopulateField()
    {
        //make five attempts to place asteroids randomly at scale 1 with 1 space of buffer
        for (int i = 0; i < 1000; i++)
        {
            int size = Random.Range(10, 20);
            Vector2Int location = new Vector2Int(Random.Range(-100, 100), Random.Range(-1000, 1000));
            if (Physics.OverlapSphere(new Vector3Int(location.x, location.y, 0), 15f + size).Length == 0)
            {
                var newAsteroid = Instantiate(asteroid, new Vector3Int(location.x, location.y, 0), Quaternion.Euler(0, 0, 0), asteroidField.transform);
                newAsteroid.transform.localScale = new Vector3(size, size, size);
            }
            
            //else if (asteroidFieldGrid[new Vector2Int(location.x, location.y)] == 0)
            //{
            //    Instantiate(asteroid, location, Quaternion.Euler(0, 0, 0), asteroidField.transform);
            //    Buffer(new Vector2Int(location.x, location.y));
            //    asteroidFieldGrid[new Vector2Int(location.x, location.y)] = 2;
            //}
            

            //Debug.Log(Random.Range(-10, 10));
        }
        //randomly place 10 asteroids with scale 10 to 20, marking space as occupied based on scale
        //for each point on the X axis, 
    }


    //private void Buffer(Vector2Int position)
    //{
    //    for (int x = position.x - 2; x <= 2; x++)
    //    {
    //        for (int y = position.y - 2; y <= 2; y++)
    //        {
    //            if (!asteroidFieldGrid.ContainsKey(position))
    //            {
    //                Debug.Log("Marking position " + position);
    //                asteroidFieldGrid.Add(position, 1);
    //                Instantiate(marker, new Vector3Int(position.x, position.y, 0), Quaternion.Euler(0, 0, 0), asteroidField.transform);
    //            }
    //            else
    //            {
    //                //Debug.Log("Position " + position + " contains the value " + asteroidFieldGrid[position]);
    //            }

    //        }
    //    }

        //for (int x = -1; x <= 1; x++)
        //{
        //    for (int y = -1; y <= 1; y++)
        //    {
        //        Debug.Log("Buffer test: " + x.ToString() + "," + y.ToString());
        //    }
        //}

    //}
}
