using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RbPlatform2 : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(40, 0, 0);
    private Rigidbody rb;
   // float inputX;
    float inputY;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        //Vector3 inputs = new Vector3((Input.GetAxis("Mouse X")), 0, (Input.GetAxis("Mouse Y")));
        //inputDirection = inputs.normalized;
        //inputX = Input.GetAxis("Mouse X");
        inputY = Input.GetAxis("Mouse Y");
    }

    public void FixedUpdate()
    {
        //Quaternion deltaRotationX = Quaternion.Euler(inputDirection.x* rotationSpeedX * Time.fixedDeltaTime);
        //Quaternion deltaRotationY = Quaternion.Euler(inputDirection.y * rotationSpeedZ * Time.fixedDeltaTime);

        Quaternion deltaRotationX = Quaternion.Euler(inputY * rotationSpeed * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation * deltaRotationX);
    }
}