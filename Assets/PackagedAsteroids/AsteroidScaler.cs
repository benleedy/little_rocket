using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //print(AsteroidSpawner.asteroidScale);
        //transform.localScale = transform.parent.transform.localScale;
        transform.localScale = new Vector3(5f, 5f, 5f);
        //print("The outer cylinder's scale is " + transform.parent.transform.lossyScale);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
