using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCollider : MonoBehaviour
{
    public int destroyTimer;
    public float rotationSpeed=3;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.Rotate(90.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.Rotate(0, 0, rotationSpeed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            Destroy(gameObject,destroyTimer);
        }

        if (other.gameObject.CompareTag("Water"))
        {
            Destroy(gameObject);
            Debug.Log("This biscuit is now soggy");
            //transform.position = new Vector3(0, 3f, 0);
        }
    }
}
