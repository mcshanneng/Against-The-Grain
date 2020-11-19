using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBiscuits : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    public Vector3 location = new Vector3(0, 0, 0);

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        Instantiate(myPrefab, location, Quaternion.identity);
    }

}
