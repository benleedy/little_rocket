using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelTracker : MonoBehaviour
{
    [SerializeField] GameObject rocketShip;
    float fuelLevel = rocketShip.fuelLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localScale.x = fuelLevel;
    }
}
