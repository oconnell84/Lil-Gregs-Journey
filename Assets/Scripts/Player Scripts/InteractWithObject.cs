using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithObject : MonoBehaviour {

    GameObject currentInteractiveObject = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey(KeyCode.E) && currentInteractiveObject)
        {
            // Do something with the object
            currentInteractiveObject.SendMessage("DoInteraction");


        }

	}

    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Item")
        {

            Debug.Log(other.name);
            currentInteractiveObject = other.gameObject;

        }


    }

    void OnTriggerExit2D(Collider2D other)
    {

        if(other.tag == "Item")
        {
            if (other.gameObject == currentInteractiveObject)
            {

                currentInteractiveObject = null;

            }


        }


    }

}
