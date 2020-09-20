using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banana : MonoBehaviour
{
	public float speed;
	public Rigidbody rb;
	public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    	float currentY = rb.velocity.y;
        Vector3 forward = target.forward * Input.GetAxis("Vertical");
        Vector3 right = target.right * Input.GetAxis("Horizontal");
        Vector3 v = forward + right;
        rb.velocity = new Vector3(v.x * speed, currentY, v.z * speed);
    }
}
