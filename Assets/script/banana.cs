using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banana : MonoBehaviour
{
	public float speed;
	public Rigidbody rb;
	public Transform target;
	private bool paused;
	private float pauseTimer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    	float currentY = rb.velocity.y;
        Vector3 forward = target.forward * -Input.GetAxis("Horizontal");
        Vector3 right = target.right * Input.GetAxis("Vertical");
        Vector3 v = forward + right;
        rb.velocity = new Vector3(v.x * speed, currentY, v.z * speed);
    }
    void Update(){
    	if(Input.GetAxis("Jump") > 0 && pauseTimer == 0){
    		paused = !paused;
    		pauseTimer = 60;
    	}
    	if(paused == true){
    		Time.timeScale = 0;
    	}
    	else{
    		Time.timeScale = 1;
    	}
    	pauseTimer -= 1;
    }
}
