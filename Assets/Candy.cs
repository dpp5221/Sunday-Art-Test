using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 4, 0);   
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.tag=="player")
        {

            gameFlow.totalCandy += 1;
            Debug.Log(gameFlow.totalCandy);
            Destroy(gameObject);

        }
    }

}
