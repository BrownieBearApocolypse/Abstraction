using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGrab : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public Item[] itemsToPickUp;

    public void Update()
    {
                
    }

    public void PickUpItem(int id)
    {
        //puts item in the slot
        inventoryManager.AddItem(itemsToPickUp[id]);       
        
    }

    public void GetSelectedItem()
        //finds items in slot
    {
        Item receivedItem = inventoryManager.GetSelectedItem(false);
        if (receivedItem != null)
        {
            Debug.Log("Reveived item:" + receivedItem);
        }
        else
        {
            Debug.Log("No item received");
        }
    }

    public void UseSelectedItem()
    {
        //item in slot is used
        Item receivedItem = inventoryManager.GetSelectedItem(true);
        if (receivedItem != null)
        {
            Debug.Log("Used item:" + receivedItem);
        }
        else
        {
            Debug.Log("No item Used");
        }
    }



}
