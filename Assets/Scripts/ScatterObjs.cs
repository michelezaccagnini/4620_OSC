using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScatterObjs : MonoBehaviour
{
    [SerializeField] float scatterRadius = 5;
    GameObject[] objs = new GameObject[10];
    Vector3[] initPos = new Vector3[10];
    float t;
    
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            objs[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            initPos[i] = Random.insideUnitSphere * 10;
            objs[i].transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        for(int i = 0; i < 10; i++)
        {
            objs[i].transform.position = initPos[i] + new Vector3(Mathf.Cos(t),0,0);
        }
    }
}
