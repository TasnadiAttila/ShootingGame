using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField]
    GameObject TorottKorong;

    public void Take_Damage()
    {
        GameObject effectOBJ = Instantiate(TorottKorong,transform.position,Quaternion.identity);
        Destroy(effectOBJ, 1);
        UImanager.Singleton.incrementTargetsHIT();
        Destroy(gameObject);
    }
}
