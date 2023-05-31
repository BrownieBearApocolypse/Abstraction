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

    private bool hideManager;

    public void Start()
    {
        InitializeInventory();
        hideManager = false;
    }

    private void Update()
    {
        SelectedSlot();
        HideDisplay();
    }

    public void InitializeInventory()
    {
        Inventory = GameObject.Find("Inventory");
        itemDisplayer = GameObject.Find("ItemDisplayer");
        itemDisplayer.SetActive(false);
        foreach (Transform Slots in Inventory.transform)
        {
            Slots.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory/Empty");
            Slots.GetComponent<Slot>().ItemProperty = Slot.Property.empty;
        }
        currentSelectedSlot = GameObject.Find("Slot");
        previousSelectedSlot = currentSelectedSlot;
    }

    public void SelectedSlot()
    {
        foreach (Transform slot in Inventory.transform)
        {
            Slot slotComponent = slot.GetComponent<Slot>();

            if (slot.gameObject == currentSelectedSlot && slotComponent.ItemProperty == Slot.Property.usable)
            {
                slot.GetComponent<Image>().color = new Color(0.6933962f, 0.9245283f, 0.7045351f, 1);
            }
            else if (slot.gameObject == currentSelectedSlot && slotComponent.ItemProperty == Slot.Property.displayable && hideManager != true)
            {
                slotComponent.DisplayItem();
                slot.GetComponent<Image>().color = new Color(0.6933962f, 0.9245283f, 0.7045351f, 1);
            }
            else
            {
                slot.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            }
            
        }
    }


    public void HideDisplay()
    {
        var slot = GameObject.Find("Inventory").GetComponent<Slot>();
        if ( Input.GetMouseButtonDown(0))
        {
            itemDisplayer.SetActive(false);
            if (currentSelectedSlot.GetComponent<Slot>().ItemProperty == Slot.Property.displayable)
            {
                // currentSelectedSlot = previousSelectedSlot;
                 previousSelectedSlot = currentSelectedSlot;
                currentSelectedSlot = null;
                hideManager = true;
            }

            //add in timeer for true to false
        }

    }
}
