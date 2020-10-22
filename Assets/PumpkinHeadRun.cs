using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinHeadRun : MonoBehaviour
{
    private string laneChange = "n";
    private string midJump = "n";

    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 3);
    }

    
    void Update()
    {

        if ((Input.GetKey(KeyCode.LeftArrow))&& (laneChange=="n") && (transform.position.x>-.9) && (midJump == "n"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-2, 0, 3);
            laneChange = "y";
            StartCoroutine(stopLaneCh());
        }

        if ((Input.GetKey(KeyCode.RightArrow))&& (laneChange == "n") && (transform.position.x<.9) && (midJump == "n"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(2, 0, 3);
            laneChange = "y";
            StartCoroutine(stopLaneCh());
        }

        if ((Input.GetKey(KeyCode.UpArrow)) && (midJump=="n") && (laneChange == "n"))
        {

            GetComponent<Rigidbody>().velocity = new Vector3(0, 2, 3);
            midJump = "y";
            StartCoroutine(stopJump());
            GetComponentInChildren<Animator>().Play("Jump");

        }


    }

    IEnumerator stopJump()
    {

        yield return new WaitForSeconds(.50f);
        GetComponent<Rigidbody>().velocity = new Vector3(0, -2, 3);
        yield return new WaitForSeconds(.50f);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 3);
        midJump = "n";

    }

    IEnumerator stopLaneCh()
    {
        yield return new WaitForSeconds(.50f);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 3);
        laneChange = "n";

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="obstacle")
        {
            Debug.Log("Ouch!");
        }
            
    }



}
