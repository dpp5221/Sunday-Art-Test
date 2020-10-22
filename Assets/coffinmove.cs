using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coffinmove : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -.2f);
    }

    
    void Update()
    {
        
    }
}
