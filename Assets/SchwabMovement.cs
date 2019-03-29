using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchwabMovement : MonoBehaviour
{

	public Rigidbody2D rb;
	//public Vector2 vel = new Vector2(0.0f, 2.0f);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(-Random.Range(0.5f, 5f), 0.0f);
    }
}
