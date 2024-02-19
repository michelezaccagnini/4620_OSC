using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingAnim1 : MonoBehaviour
{
    [SerializeField] Transform oscObj;
    bool was_on;
    float bounce = 0;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //VCV scaling 0-10
        float adsr = oscObj.position.x * 0.1f;
        float eps = 0.01f;
        if (adsr > eps && !was_on)
        {
            bounce = 0;
        }
        else if(adsr > 0 && was_on)
        {
            
            if (bounce < 1)
                bounce += Time.deltaTime;
            else
                bounce -= Time.deltaTime;
            transform.position = new Vector3(0, 1-Mathf.Pow(bounce,0.3f), 0);
        }
        was_on = adsr > eps;
    }
}
