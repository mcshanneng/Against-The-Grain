using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offsetScript : MonoBehaviour
{
    float timer;
    public float scrollSpeedX = 0.5f;
    public float scrollSpeedY = 0.5f;
    Renderer rend;

    void Start()
    {
        timer = 0;
        rend = GetComponent<Renderer>();
    }


    void Update()
    {
        float offsetX = Time.time * scrollSpeedX;
        float offsetY = Time.time * scrollSpeedY;
        //float testX
        rend.material.SetTextureOffset("_MainTex", new Vector2((Mathf.Cos(offsetX)/10), (Mathf.Cos(offsetY) / 8)));
    }

}
