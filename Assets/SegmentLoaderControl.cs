using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* The segment loader is a framework for new asteroid fields.  When the player docks
 * on a platform they are stabilized.  When this happens the loader takes a step to the next
 * space where asteroids should be generated.  First wall are established.  Then a landing
 * platform is placed.  Finally the asteroids are generated.
 * 
 * Once the segment is ready for asteroids, an array is filled with every grid point in the
 * space.  Any that are occupied by wall outcroppings or the landing platform are immediately
 * stricken from the array.
 * 
 * Starting with the largest size desired, the spawner's scale is set and it is given a
 * random number from the array.  It starts at that grid point, then starts walking the
 * array until a suitable point is found.  The asteroid is placed and all grid points that
 * are now covered by the asteroid's outer boundary are now stricken from the list.
 * 
 * This process continues as the size of the asteroid decreases.  If the entire array is
 * traversed without finding a suitable location for an asteroid, the scale is reduced. If
 * this happens at the smallest desired scale, the script is now finished.
 */

public class SegmentLoaderControl : MonoBehaviour
{
    [SerializeField] GameObject playerRocket;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
