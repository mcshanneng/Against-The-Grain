using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collecting : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float rotationSpeed;
    public TextMeshProUGUI countText;
    public GameObject biscuitA;
    public GameObject biscuitB;
    public GameObject biscuitC;
    public GameObject biscuitD;
    public GameObject biscuitE;

    int count;
    //private Vector3 rotation = new Vector3(0, rotationSpeed, 0);

    float turnSmoothVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        biscuitA.SetActive(false);
        biscuitB.SetActive(false);
        biscuitC.SetActive(false);
        biscuitD.SetActive(false);
        biscuitE.SetActive(false);
    }
    void Update()
    {
        // Inputs (right now it uses WASD inputs)
        float mH = Input.GetAxis("Horizontal");
        float mV = Input.GetAxis("Vertical");

        //Rotation and Movement
        Vector3 rotation = new Vector3(0, rotationSpeed, 0);
        rb.AddForce(new Vector3(mH * speed, rb.velocity.y, mV * speed)); //THis movement makes it seem like the surface is icy/slippery

        //Makes the spinning dpend on how fast the Dog is moving
        if (rb.velocity.magnitude > 0.2)
        {
            Quaternion deltaRotationY = Quaternion.Euler(rotation * (rb.velocity.magnitude / 4) * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotationY);
        }

    }
    void SetCountText()
    {
        countText.text = "Biscuits Collected: " + count.ToString();

        if (count >= 1)
          {
            biscuitA.SetActive(true);
          }
        if (count >= 5)
        {
            biscuitB.SetActive(true);
        }
        if (count >= 10)
        {
            biscuitC.SetActive(true);
        }
        if (count >= 15)
        {
            biscuitD.SetActive(true);
        }
        if (count >= 20)
        {
            biscuitE.SetActive(true);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DogBiscuit"))
        {

            //Instantiate(other.gameObject, new Vector3(Random.Range(-30, 30), 20, Random.Range(-30, 30)), Quaternion.identity);
            Destroy(other.gameObject);
            count++;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Water"))
        {
            //Destroy(gameObject);
            transform.position = new Vector3(0,3f, 0);
        }
    }
}
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DogBiscuit"))
        {
            other.gameObject.SetActive(false);
            count++;

            SetCountText();
        }
    }
    */
