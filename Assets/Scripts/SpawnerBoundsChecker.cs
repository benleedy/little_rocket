using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBoundsChecker : MonoBehaviour
{
    //variables for sphere casting
    //for origin use transform.position
    private Vector3 origin;
    //for radius use asteroidScale
    private float asteroidScale;
    public float maxDistance = 180f;
    public LayerMask layerMask;
    private Vector3 direction;
        RaycastHit hit;



    // Start is called before the first frame update
    void Start()
    {
        
        asteroidScale = 20f;
        origin = gameObject.transform.position;
        direction = gameObject.transform.forward;
    }

    private void FixedUpdate()
    {
        if (Physics.SphereCast(origin - new Vector3(0f, 0f, 5f), asteroidScale, direction, out hit, maxDistance, layerMask))
        {
            //print("Destroying!");
            Destroy(gameObject);
        }
        else
        {
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {


    }
}
