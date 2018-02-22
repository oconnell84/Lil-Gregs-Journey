using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOverTime : MonoBehaviour {

    public float timeToDestroy = 2f;
    private float currentTime = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (currentTime >= timeToDestroy)
        {

            Destroy(gameObject);

        }

        currentTime += Time.deltaTime;
    }
}
