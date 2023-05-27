using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public GameObject currentSelectedSlot { get; set; }
    public GameObject previousSelectedSlot { get; set; }

    private GameObject slots;

    void Start()
    {
        InitializeInventory();
        slots = GameObject.Find("Inventory");
    }

    private void Update()
    {
        SelectedSlot();
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

    void SelectedSlot()
    {
        foreach (Transform slot in slots.transform)
        {
            if(slots.gameObject == currentSelectedSlot && slot.GetComponent<Slot>().ItemProperty == Slot.Property.usable)
            {
                slot.GetComponent<Image>().color = new Color(0.9f, 0.4f, 0.6f, 1);
            }
            else
            {
                slot.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            }
        }
    }
}
