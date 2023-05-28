using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public GameObject currentSelectedSlot { get; set; }
    public GameObject previousSelectedSlot { get; set; }

    private GameObject Inventory;
    public GameObject itemDisplayer { get; private set; }

    void Start()
    {
        InitializeInventory();
    }

    private void Update()
    {
        SelectedSlot();
        HideDisplay();
    }

    void InitializeInventory()
    {
        Inventory = GameObject.Find("Inventory");
        itemDisplayer = GameObject.Find("ItemDisplayer");
        itemDisplayer.SetActive(false);
        foreach (Transform Slots in Inventory.transform)
        {
            Slots.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory/Empty");
            Slots.GetComponent<Slot>().ItemProperty = Slot.Property.empty;
        }
        currentSelectedSlot = GameObject.Find("slot");
        previousSelectedSlot = currentSelectedSlot;
    }

    void SelectedSlot()
    {
        foreach (Transform slot in Inventory.transform)
        {
            if(Inventory.gameObject == currentSelectedSlot && slot.GetComponent<Slot>().ItemProperty == Slot.Property.usable)
            {
                slot.GetComponent<Image>().color = new Color(0.9f, 0.4f, 0.6f, 1);
            }
            else if(slot.gameObject == currentSelectedSlot && slot.GetComponent<Slot>().ItemProperty == Slot.Property.displayable)
            {
                //slot.GetComponent<Slot>().DisplayItem();
            }
            else
            {
                slot.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            }
        }
    }

    public void HideDisplay()
    {
        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {
            itemDisplayer.SetActive(false);
            if (currentSelectedSlot.GetComponent<Slot>().ItemProperty == Slot.Property.displayable)
            {
                currentSelectedSlot = previousSelectedSlot;
                previousSelectedSlot = currentSelectedSlot;
            }
        }
    }
}
