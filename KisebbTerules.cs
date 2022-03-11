using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KisebbTerules : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.y > 0.2f)
        {     
            transform.localScale -= new Vector3(Time.deltaTime, Time.deltaTime, Time.deltaTime);
        }
        
    }
}
