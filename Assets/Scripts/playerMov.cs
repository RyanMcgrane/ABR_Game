using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMov : MonoBehaviour {

    public Rigidbody rb;

    public float speed = 2000f;
    public float sideways = 500f;
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);

        if ( Input.GetKey("right"))
        {
            rb.AddForce(sideways * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("left"))
        {
            rb.AddForce(-sideways *Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
