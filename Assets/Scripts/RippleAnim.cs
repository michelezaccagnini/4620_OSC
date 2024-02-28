using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RippleAnim : MonoBehaviour
{
    [SerializeField] Transform oscObj;
    Material mat;
    float accum;
    
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        float adsr = oscObj.position.x * 0.1f ;
        accum -= adsr * Time.deltaTime;
        mat.SetFloat("_Envelope", accum);
    }
}
