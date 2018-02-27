using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    
    public GameObject[] inventory = new GameObject[10];
    public Button[] InventoryButtons = new Button[10];

    public void AddItem(GameObject item)
    {

        bool itemAdded = false;

        // Find first open slot in inventory
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == null)
            {
                inventory[i] = item;
                // Update UI
                InventoryButtons[i].image.overrideSprite = item.GetComponent<SpriteRenderer>().sprite;
                Debug.Log(item.name + " was added");
                itemAdded = true;
                // Do something with the object
                item.SendMessage("DoInteraction");

                break;

            }

           
        }

        // Inventory full
        if (!itemAdded)
        {

            Debug.Log("Inventory Full - Item not added");

        }


    }

    private bool checkForItem(string itemName)
    {

        for (int i = 0; i < inventory.Length; i++)
        {

            // if there is no object at position i, go to next position
            if (inventory[i] == null)
            {

                i++;

            }

            // if there is an object, check if name matches
            else if (inventory[i].name == itemName)
            {

                return true;

            }


        }

        return false;

    }

    private int getItemPosition(string itemName)
    {

        if (!checkForItem(itemName))
        {

            return -1;

        }

        else
        {
            for (int i = 0; i < inventory.Length; i++)
            {

                // if there is no object at position i, go to next position
                if (inventory[i] == null)
                {

                    i++;

                }

                // if there is an object, check if name matches
                else if (inventory[i].name == itemName)
                {

                    return i;

                }


            }

            return -1;

        }

    }

}
