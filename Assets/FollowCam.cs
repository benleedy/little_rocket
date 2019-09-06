using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FollowCam : MonoBehaviour
{
    [SerializeField] Transform playerRocketTransform;
    [SerializeField] Rigidbody playerRocketRigidbody;
    //float cameraDistance = 9;
    float cameraLead = 1;
    float rocketVelocity = 0;
    [SerializeField] Vector3 cameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraLead = playerRocketRigidbody.velocity.y / 5;
        if (cameraLead > 5f)
        {
            cameraLead = 5f;
        }
        //rocketVelocity = Time.deltaTime . . fix this so the camera leads the rocket based on speed
        float differenceFromRocket = playerRocketTransform.position.y - transform.position.y + cameraLead + 4;
        print(playerRocketRigidbody.velocity.y);
        
        if (playerRocketTransform.position.y >= 9f)
        {
            transform.Translate(0, differenceFromRocket, 0);
        }
        /*
        else
        {
            transform.Translate(0f, 9f, -25f);
        }
        */
        //        print(transform.position.y);
        //        print(playerRocket.position.y);
    }
}
