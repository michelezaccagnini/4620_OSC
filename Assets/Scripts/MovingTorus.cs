using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTorus : MonoBehaviour
{
    [SerializeField] Transform oscObj;
    bool was_on;
    Material mat;
    GameObject torus;
    [SerializeField] Vector3 init_pos;
    [SerializeField] Vector3 final_pos;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
        mat.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        //VCV scaling 0-10
        float adsr = oscObj.position.x * 0.1f;
        float eps = 0.01f;
        if (adsr > eps && !was_on)
        {
            torus = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            torus.transform.position = new Vector3(0, 0, -3);
        }
        else if(adsr < eps)
        {
            Destroy(torus);
        }
        else if(adsr > eps && was_on)
        {
            torus.transform.position = Vector3.Lerp(init_pos, final_pos,1-adsr );
            torus.transform.localScale = new Vector3(adsr, adsr, adsr) * 8;
        }
        was_on = adsr > eps;
    }
}
