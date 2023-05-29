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

    public void Start()
    {
        InitializeInventory();
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
                slot.GetComponent<Image>().color = new Color(0.4f, 0.6f, 0.2f, 1);
            }
            else if (slot.gameObject == currentSelectedSlot && slotComponent.ItemProperty == Slot.Property.displayable)
            {
                slotComponent.DisplayItem();
                slot.GetComponent<Image>().color = new Color(0.4f, 0.6f, 0.2f, 1);
            }
            else
            {
                slot.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            }
        }
    }


    public void HideDisplay()
    {
        if (!UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {
            itemDisplayer.SetActive(false);
            if (currentSelectedSlot.GetComponent<Slot>().ItemProperty == Slot.Property.displayable) // need someting here?
            {
                currentSelectedSlot = previousSelectedSlot;
                previousSelectedSlot = currentSelectedSlot;
            }
        }

    }
}
