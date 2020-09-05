using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScreenInputHandler : MonoBehaviour
{
    [SerializeField] float rcsThrust = 100f;
    [SerializeField] Rocket myRocket;
    public bool boosting = false;
    public bool turningLeft = false;
    public bool turningRight = false;

    private void Update()
    {
        CheckBoosting();
        CheckLeftTurning();
        CheckRightTurning();
        
    }

    private void CheckBoosting()
    {
        if (!boosting)
        {
            return;
        }
        else
        {
            FindObjectOfType<Rocket>().ApplyThrust();
        }
    }

    public void Boost(bool boost)
    {
        boosting = boost;
    }

    public void TurnLeft(bool turnLeft)
    {
        turningLeft = turnLeft;
    }

    private void CheckLeftTurning()
    {
        if (!turningLeft)
        {
            return;
        }
        else
        {
            float xThrow = -1f;

            float rotationThisFrame = -xThrow * Time.deltaTime * rcsThrust;

            myRocket.transform.Rotate(Vector3.forward * rotationThisFrame);

        }
    }

    public void TurnRight(bool turnRight)
    {
        turningRight = turnRight;
    }

    private void CheckRightTurning()
    {
        if (!turningRight)
        {
            return;
        }
        else
        {
            float xThrow = 1f;

            float rotationThisFrame = -xThrow * Time.deltaTime * rcsThrust;

            myRocket.transform.Rotate(Vector3.forward * rotationThisFrame);

        }
    }
}
