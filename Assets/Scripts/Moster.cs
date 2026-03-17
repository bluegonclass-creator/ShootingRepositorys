using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moster : MonoBehaviour
{
    public float spd = 1.0f;
    Vector3 direct = Vector3.down;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + direct * spd * Time.deltaTime;    
    }
}
