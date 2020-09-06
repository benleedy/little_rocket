using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolloowCamZeroG : MonoBehaviour
{
    [SerializeField] Transform playerRocketTransform;
    //float cameraDistance = 9;
    [SerializeField] Vector3 cameraPosition;
    [SerializeField] float cameraDistance = 100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (playerRocketTransform.position.y <= 21f)
        //{
        //    transform.position = new Vector3(0f, 21f, -82f);
        //}
        //else
        //{
            transform.position = new Vector3(playerRocketTransform.position.x, playerRocketTransform.position.y, -cameraDistance);
        //}

        /*
        transform.position = new Vector3(0f, playerRocketTransform.position.y, -82f);
        print(transform.position);

    
        */
    }
}
