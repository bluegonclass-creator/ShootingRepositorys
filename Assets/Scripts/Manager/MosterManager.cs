using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MosterManager : MonoBehaviour
{
    public GameObject prefabsMoster;

    // Update is called once per frame
    void Update()
    {
        GameObject monster = Instantiate(prefabsMoster);
        monster.transform.position = transform.position;
    }
}
