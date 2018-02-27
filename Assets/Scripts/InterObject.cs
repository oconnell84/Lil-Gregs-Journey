using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterObject : MonoBehaviour {


    public bool inventory;      // if true, this object can be stored in inventory

    public void DoInteraction()
    {
        // Picked up and put in inventory
        gameObject.SetActive(false);

    }
}
