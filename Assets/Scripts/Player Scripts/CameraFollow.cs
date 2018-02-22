﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float camSize = 3f;
    public float cam_speed = 0.1f;
    Camera mycam;

	// Use this for initialization
	void Start () {

        mycam = GetComponent<Camera>();
        

	}
	
	// Update is called once per frame
	void Update () {

        mycam.orthographicSize = (Screen.height / 100f) / camSize;
        
        if (target)
        {
            // lerp is (From, To, Howfast)
            transform.position = Vector3.Lerp(transform.position, target.position, cam_speed) + new Vector3(0,0,-10);

        }
        	
	}
}
