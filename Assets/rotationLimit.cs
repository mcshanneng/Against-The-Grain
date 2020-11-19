using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationLimit : MonoBehaviour
{
    public float minRotation = -45;
    public float maxRotation = 45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 currentRotation = transform.localRotation.eulerAngles;
        currentRotation.x = Mathf.Clamp(currentRotation.z, minRotation, maxRotation);
        transform.localRotation = Quaternion.Euler(currentRotation);
    }
}
