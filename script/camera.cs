﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
	private Vector3 offset;
	public Transform target;
	public Transform player;
	public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        offset = target.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
    	target.position = player.position;
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.Rotate(0, horizontal, 0);
        
        float desiredYAngle = target.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredYAngle, 0);
        transform.position = target.position - (rotation * offset);
        transform.position += new Vector3(0, 15, 0);
        //transform.position = target.position - offset;
        transform.LookAt(target);
    }
}