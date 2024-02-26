using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationSimple : MonoBehaviour
{
    float t;
    Vector3 init_pos;
    bool was_trig;
    float env;
    float rota;
    // Start is called before the first frame update
    void Start()
    {
        init_pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float freq = 0.5f;
        t += Time.deltaTime;
        int t_int = Mathf.FloorToInt(t % freq);
        bool is_on = t_int == 0;

        if(is_on && !was_trig)
        {
            env = 0;
            rota = 0;
        }
        else if(is_on)
        {
            env += Time.deltaTime * freq;
            rota = Mathf.Pow(env, 3);
            Debug.Log(rota);
        }
        
        transform.position = Quaternion.Euler(0,rota , 0) *init_pos ;
        was_trig = is_on;
    }
}
