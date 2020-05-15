using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {

        Vector3 terrainSize = GameObject.Find("Terrain").GetComponent<Terrain>().terrainData.size;

        for (int i = 0; i < 750; i++)
        {
            // Instantiate at random position and zero rotation.
            Instantiate(myPrefab, new Vector3(Random.Range(0, terrainSize.x), 0.5f, Random.Range(0, terrainSize.z)), Quaternion.identity);
        }
        
    }
}
