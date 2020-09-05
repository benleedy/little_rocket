using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Asteroid : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.SetParent(FindObjectOfType<AsteroidField>().gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                0f
            );
    }
}
