using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTest : MonoBehaviour
{
    public InventoryManager inventoryManager;

    public void OnMouseDown()
    {
        inventoryManager.AddItem();
    }
}
