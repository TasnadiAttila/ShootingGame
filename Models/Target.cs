using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField]
    GameObject ParticalEffect;

    public void Take_Damage()
    {
        
       // GameObject effectOBJ = Instantiate(ParticalEffect,transform.position,Quaternion.identity);
       // Destroy(effectOBJ, 1);
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
