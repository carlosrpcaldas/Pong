using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer_Input_Controller : MonoBehaviour {

    public GameObject leftBat;
    public GameObject rightBat;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {


        leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

        if (Input.GetKey(KeyCode.W))
        {

            leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 5f, 0f);

        }

        else if (Input.GetKey(KeyCode.S))
        {

            leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -5f, 0f);

        }


        rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

        if (Input.GetKey(KeyCode.UpArrow))
        {

            rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 5f, 0f);

        }

        else if (Input.GetKey(KeyCode.DownArrow ))
        {

            rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -5f, 0f);

        }


    }
}
