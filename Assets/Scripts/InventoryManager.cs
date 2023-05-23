using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    void Start()
    {
        InitializeInventory();
    }

    void InitializeInventory()
    {
        var Inventory = GameObject.Find("Inventory");
        foreach (Transform Slot in Inventory.transform)
        {
            Slot.transform.GetChild(0).GetComponent<Image>().sprite =
                Resources.Load<Sprite>("Inventory/Empty");
        }
    }
}
