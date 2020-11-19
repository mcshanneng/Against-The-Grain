using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class biscuitScript : MonoBehaviour
{
    //int count= 0;
    // Start is called before the first frame update
    public float initialSpawn = 3f;
    public float spawnTime = 3f;
    public GameObject biscuit;
    void Start()
    {
        InvokeRepeating("SpawnBall", initialSpawn, spawnTime);
    }

    // Update is called once per frame
    void Udpdate()
    {
        //Instantiate(gameObject, new Vector3(Random.Range(-30, 30), 20, Random.Range(-30, 30)), Quaternion.identity);
       Destroy(gameObject, 4);
    }
    void SpawnBall()
    {
        var newBall = Instantiate(biscuit, new Vector3(Random.Range(-30, 30), 20, Random.Range(-30, 30)), Quaternion.identity);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            Destroy(biscuit,3);
        }
        
        if (other.gameObject.CompareTag("Water"))
        {
            Destroy(gameObject);
            Debug.Log("RIP");
        }
        
    }

}
