using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    [SerializeField] Transform oscObj;
    bool was_on;
    Material mat;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        //VCV scaling 0-10
        float adsr = oscObj.position.x *0.1f;
        float eps = 0.01f;
        if(adsr > eps && !was_on)
        {
            //change color
            Color col = Random.ColorHSV();
            mat.color = col;

        }
        was_on = adsr > eps;
    }
}
