using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivorGenerator : MonoBehaviour
{
    [SerializeField] Transform survivorPrefab;
    [SerializeField] Transform SurvivorList;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateSurvivors()
    {
        Vector3Int location = new Vector3Int(Random.Range(-100, 100), Random.Range(-100, 100), 0);
        if (Physics.OverlapSphere(location, 5f).Length == 0)
        {
            Instantiate(survivorPrefab, location, Quaternion.identity, SurvivorList);
        }
    }
}
