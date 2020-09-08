using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Survivor : MonoBehaviour
{
    [SerializeField] int points = 5;
    [SerializeField] Transform arrow;
    
    Vector3 screenPos;
    Vector2 onScreenPos;
    float max;
    Camera camera;

    //Lerping setup
    public int interpolationFramesCount = 45; // Number of frames to completely interpolate between the 2 positions
    int elapsedFrames = 0;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 0f);

        screenPos = camera.WorldToViewportPoint(transform.position);


        var angleToTarget = Vector2.Angle(FindObjectOfType<Player>().transform.position, transform.position);

        //Debug.Log("Target is at bearing" + angleToTarget);

        //Lerping
        float interpolationRatio = (float)elapsedFrames / interpolationFramesCount;

        Vector3 interpolatedPosition = Vector3.Lerp(FindObjectOfType<Player>().transform.position, transform.position, interpolationRatio);
        float space = 5f / Vector3.Distance(FindObjectOfType<Player>().transform.position, transform.position);
        arrow.transform.position = Vector3.Lerp(FindObjectOfType<Player>().transform.position, transform.position, space);
        arrow.LookAt(transform.position);

        elapsedFrames = (elapsedFrames + 1) % (interpolationFramesCount + 1);  // reset elapsedFrames to zero after it reached (interpolationFramesCount + 1)
        
        Debug.DrawLine(FindObjectOfType<Player>().transform.position, transform.position, Color.green);
        Debug.DrawLine(Vector3.zero, Vector3.forward, Color.blue);
        Debug.DrawLine(FindObjectOfType<Player>().transform.position, interpolatedPosition, Color.yellow);


        //if(screenPos.x > 0 && screenPos.x <= 1 && screenPos.y >= 0 && screenPos.y <= 1)
        //{
        //    Debug.Log("already on screen");
        //    return;
        //}

        //onScreenPos = new Vector2(screenPos.x - 0.5f, screenPos.y - 0.5f) * 2;
        //max = Mathf.Max(Mathf.Abs(onScreenPos.x), Mathf.Abs(onScreenPos.y));
        //onScreenPos = (onScreenPos / (max * 2)) + new Vector2(0.5f, 0.5f);
        //Debug.Log(onScreenPos);
        //var visibleSphere = UISphere.transform;
        //visibleSphere.position = onScreenPos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponentInParent<Player>().IncreaseScore(points);
            Destroy(gameObject);
        }
    }
}
