using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class banana : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    public Transform target;
    public Transform fruitT;
    private bool paused;
    private float pauseTimer;
    private bool jellied;
    public float jelliedTimer;
    private bool colliding;
    private string fruit;
    private float currentY;
    private bool cake;
    private bool spooned;
    public Transform splat;
    public Transform spoon;
    public static bool bowl;
    public AudioSource collide;
    void Start(){
        rb = GetComponent<Rigidbody>();
        fruitT = GetComponent<Transform>();
        spooned = false;
    }

    void FixedUpdate(){
    splat.localScale = new Vector3(0f, 0f, 0f);
    	if(colliding == true){
    		if(cake == true){
    			currentY = 0;
    		}
    		if(spooned == true){
    			currentY = 0;
    		}
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
                currentY += 1.5f;
            }
        }
        jelliedTimer -= 1;
        if(jelliedTimer == 0f){
        	jellied = false;
        }
        splat.position = fruitT.position;
        if(spooned == false){
        	rb.velocity = new Vector3(v.x * speed, currentY, v.z * speed);
    	}
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
        collide.Play();
        if(collision.gameObject.tag == "jelly"){
        	jellied = true;
        	jelliedTimer = 1500f;
        }
        if(collision.gameObject.tag == "cake"){
        	cake = true;
        }
        else{
        	cake = false;
        }
        if(collision.gameObject.tag == "knife"){
        	transform.position = new Vector3(-11f, 23f, 73f);
        }
        if(collision.gameObject.tag == "spoon"){
        	spooned = true;
        	rb.velocity = new Vector3(0f, spoon.up.y + 15, spoon.forward.z - 15);
        }
        else{
        	spooned = false;
        }
        if(collision.gameObject.tag == "bowl"){
        	bowl = true;
        }
    }
    void OnCollisionExit(Collision collision){
        colliding = false;
    }
}
