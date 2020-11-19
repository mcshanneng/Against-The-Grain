using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformTilt : MonoBehaviour
{
    public Vector3 currentRot;
    public int zRotationLimitL= 50;
    public int zRotationLimitR= 308;
    public int xRotationLimitL = 10;
    public int xRotationLimitR = 308;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentRot = GetComponent<Transform>().eulerAngles;


        if ((Input.GetAxis("Mouse X") > 0.2) && (currentRot.z <= zRotationLimitL || currentRot.z >= zRotationLimitR))
        {
            transform.Rotate(0, 0, -1);
        }
        if ((Input.GetAxis("Mouse X") < -0.2) && (currentRot.z >= zRotationLimitR -1 || currentRot.z <= zRotationLimitL-1))
        {
            transform.Rotate(0, 0, 1);
        }

        if ((Input.GetAxis("Mouse Y") > 0.2) && (currentRot.x <= xRotationLimitL || currentRot.x >= xRotationLimitR))
        {
            transform.Rotate(-1, 0, 0);
        }
        if ((Input.GetAxis("Mouse Y") < -0.2) && (currentRot.x >= xRotationLimitR - 1 || currentRot.x <= xRotationLimitL - 1))
        {
            transform.Rotate(1, 0, 0);
        }
    }
}
