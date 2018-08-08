using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour {


    Rigidbody rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();

        int xDirection = Random.Range(0, 2);
        int yDirection = Random.Range(0, 3);

        Vector3 launchDirectorion = new Vector3();

        if(xDirection == 0)
        {
            launchDirectorion.x = -8f;
        }
        if(xDirection == 1)
        {
            launchDirectorion.x = 8f;
        }

        if (yDirection == 0)
        {
            launchDirectorion.y = -8f;
        }
        if (yDirection == 1)
        {
            launchDirectorion.y = 8f;
        }
        if (yDirection == 2)
        {
            launchDirectorion.y = 0f;
        }

        rb.velocity = launchDirectorion;

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter (Collision hit)
    {
        if (hit.gameObject.name == "TopBound")
        {

            float speedInXDirection = 0f;

            if (rb.velocity.x > 0f)
            {
                speedInXDirection = 8f;
            }

            if(rb.velocity.x < 0f) { 
                speedInXDirection = -8f;
            }

        rb.velocity = new Vector3(speedInXDirection, -8f, 0f);



        }
        if (hit.gameObject.name == "BottomBound")
        {

            float speedInXDirection = 0f;

            if (rb.velocity.x > 0f)
            {
                speedInXDirection = 8f;
            }

            if (rb.velocity.x < 0f)
            {
                speedInXDirection = -8f;
            }

            rb.velocity = new Vector3(speedInXDirection, 8f, 0f);
        }

        if (hit.gameObject.name == "Left_Bat")
        {
            rb.velocity = new Vector3(13f, 0f, 0f);

            if (transform.position.y - hit.gameObject.transform.position.y < -2)
            {
                rb.velocity = new Vector3(8f, -8f, 0f);
            }
            if (transform.position.y - hit.gameObject.transform.position.y < 2)
            {
                rb.velocity = new Vector3(8f, 8f, 0f);
            }
        }
        if (hit.gameObject.name == "Right_Bat")
        {
            rb.velocity = new Vector3(-13f, 0f, 0f);

            if (transform.position.y - hit.gameObject.transform.position.y < -2)
            {
                rb.velocity = new Vector3(-8f, -8f, 0f);
            }
            if (transform.position.y - hit.gameObject.transform.position.y < 2)
            {
                rb.velocity = new Vector3(-8f, 8f, 0f);
            }

        }

    }
}
