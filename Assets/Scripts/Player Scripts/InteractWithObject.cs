using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithObject : MonoBehaviour {

    public GameObject currentInteractiveObject = null;
    public InterObject currentInterObjectScript = null;
    public Inventory inventory;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey(KeyCode.E) && currentInteractiveObject)
        {

            // Check if object can be stored in inventory
            if (currentInterObjectScript.inventory)
            {

                inventory.AddItem(currentInteractiveObject);

            }

            

        }

	}

    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Item")
        {

            Debug.Log(other.name);
            currentInteractiveObject = other.gameObject;
            currentInterObjectScript = currentInteractiveObject.GetComponent<InterObject>();

        }


    }

    void OnTriggerExit2D(Collider2D other)
    {

        if(other.tag == "Item")
        {
            if (other.gameObject == currentInteractiveObject)
            {
                //Debug.Log("Object exited");
                currentInteractiveObject = null;

            }


        }


    }

}
