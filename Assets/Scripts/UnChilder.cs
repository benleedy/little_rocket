using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnChilder : MonoBehaviour
{
    private float curPos;
    private float lastPos;
    // Start is called before the first frame update
    void Start()
    {
        lastPos = 0f;
        //StartCoroutine("WaitOneSecond");
    }

    // Update is called once per frame
    void Update()
    {
        curPos = transform.position.y;
        if (curPos == lastPos);
        {
            foreach (Transform child in transform)
            {
                //print(curPos);
               // print(lastPos);
                child.parent = null;
            }
        }
        lastPos = curPos;
    }
    /*
    IEnumerator WaitOneSecond()
    {
        yield return new WaitForSeconds(1);
        checkVelocity = true;
    }*/
}
