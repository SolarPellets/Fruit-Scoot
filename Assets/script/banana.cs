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
    public bool jellied;
    public float jelliedTimer;
    public bool colliding;
    public string fruit;
    public float currentY;
    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
    	if(colliding == true){
    		if(currentY < -10){
    			transform.position = new Vector3(-11f, 23f, 73f);
    		}
    	}
        currentY = rb.velocity.y;
        Vector3 forward = target.forward * -Input.GetAxis("Horizontal");
        Vector3 right = target.right * Input.GetAxis("Vertical");
        Vector3 v = forward + right;
        if(jellied && colliding){
            if(Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0){
                currentY += 1;
            }
        }
        jelliedTimer -= 1;
        if(jelliedTimer == 0f){
        	jellied = false;
        }
        rb.velocity = new Vector3(v.x * speed, currentY, v.z * speed);
    }
    void Update(){
        if(Input.GetAxisRaw("Jump") * Time.unscaledDeltaTime > 0){
            if(pauseTimer < 0){
                paused = !paused;
                pauseTimer = 0.5f;
            }
        }
        if(paused == true){
            Time.timeScale = 0;
        }
        else{
            Time.timeScale = 1;
        }
        pauseTimer -= Time.unscaledDeltaTime;
    }
    void OnCollisionEnter(Collision collision){
        colliding = true;
        if(collision.gameObject.tag == "jelly"){
        	jellied = true;
        	jelliedTimer = 1500f;
        }
    }
    void OnCollisionExit(Collision collision){
        colliding = false;
    }
}
