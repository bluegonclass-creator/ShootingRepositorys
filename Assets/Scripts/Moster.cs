using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Moster : MonoBehaviour
{
    public float spd = 1.0f;

    //Hierarchy에서 Character를 넣는다
    public GameObject target; 
    
    Vector3 direct = Vector3.down;
     
    private void Start()
    {
        target = GameObject.Find("Character");

        int rndNum = Random.Range(0, 10);  
        if(rndNum % 3 == 0) //3의 배수
        {  
            direct = target.transform.position - transform.position; 
            direct.Normalize();
        }
    }
    
    void Update()
    {
        transform.position = transform.position + direct * spd * Time.deltaTime;     
    }
     
    private void OnCollisionEnter(Collision collision)
    { 
        Destroy(collision.gameObject); 
        Destroy(gameObject);
    }
}


