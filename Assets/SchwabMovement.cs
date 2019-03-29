using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchwabMovement : MonoBehaviour
{

	public Rigidbody2D rb;
	private float vel = 0;
	private float vel2 = 0;
    // Start is called before the first frame update
    void Start()
    {
    	vel = Random.Range(0.5f, 5f);
		vel2 = Random.Range(-0.5f, 0.5f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(-vel, vel2);
    }
}
