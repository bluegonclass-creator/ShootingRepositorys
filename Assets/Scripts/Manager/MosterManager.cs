using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MosterManager : MonoBehaviour
{
    public GameObject prefabsMoster;

    float nowTime;
    public float createTime = 1f;

    // Update is called once per frame
    void Update()
    {
        nowTime = nowTime + Time.deltaTime;
        
        if (nowTime < createTime)
        {
            GameObject monster = Instantiate(prefabsMoster);
            monster.transform.position = transform.position;
        }
    }
}
