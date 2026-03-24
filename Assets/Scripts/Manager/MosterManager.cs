using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MosterManager : MonoBehaviour
{ 
    public GameObject prefabsMoster;

    float nowTime;
    float minTime = 1f; 
    float maxTime = 5f; 
    public float createTime = 1f;

    private void Start()
    { 
        createTime = Random.Range(minTime, maxTime);
    }

    void Update()
    {
        nowTime = nowTime + Time.deltaTime;  

        if (nowTime > createTime)
        {
            GameObject monster = Instantiate(prefabsMoster);
            monster.transform.position = transform.position;
            
            //랜덤 함수 추가
            createTime = Random.Range(minTime, maxTime); 

            nowTime = 0; 
        }
    }
}




/*
// Update is called once per frame

    float nowTime;


    public float createTime = 1f;

void Update()
{
    nowTime = nowTime + Time.deltaTime;

    if (nowTime > createTime)
    {
        GameObject monster = Instantiate(prefabsMoster);
        monster.transform.position = transform.position;

        createTime = Random.Range(minTime, maxTime);

        nowTime = 0;
    }
}

 */

