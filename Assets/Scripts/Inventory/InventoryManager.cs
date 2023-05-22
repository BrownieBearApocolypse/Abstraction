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
        var slots = GameObject.Find("Inventory");
        foreach (Transform slot in slots.transform)
        {
            slot.transform.GetChild(0).GetComponent<Image>().sprite =
                Resources.Load<Sprite>("Inventory/Empty");
        }
    }
}
