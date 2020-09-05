using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidColor : MonoBehaviour
{
    [SerializeField] Transform childCube;


    private void OnCollisionEnter(Collision collision)
    {
        print("I'm colliding!");
        childCube.GetComponent<Renderer>().material.color = Color.red;
    }
}
