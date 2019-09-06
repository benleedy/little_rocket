using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FollowCam : MonoBehaviour
{
    [SerializeField] Transform playerRocket;
    //float cameraDistance = 9;
    float cameraLead = 1;
    float rocketVelocity = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rocketVelocity = Time.deltaTime . . fix this so the camera leads the rocket based on speed
        float differenceFromRocket = playerRocket.position.y - transform.position.y + cameraLead;
        transform.Translate(0, differenceFromRocket, 0);
        //        print(transform.position.y);
        //        print(playerRocket.position.y);
    }
}
