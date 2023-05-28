using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerClickHandler
{
    private GameObject inventory;   

    private string displayImage;
    public string combineItem { get; set; }
    public enum Property { usable, displayable, empty };
    public Property ItemProperty { get; set; }

    public void Start()
    {
        inventory = GameObject.Find("Inventory");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        inventory.GetComponent<InventoryManager>().SelectedSlot();
        inventory.GetComponent<InventoryManager>().previousSelectedSlot = inventory.GetComponent<InventoryManager>().currentSelectedSlot;
        inventory.GetComponent<InventoryManager>().currentSelectedSlot = this.gameObject;
        Combine();
        if (ItemProperty == Slot.Property.displayable)
        {
            DisplayItem();
        }
    }

    public void AssignProperty(int orderNumber, string displayImage, string combineItem)
    {
        ItemProperty = (Property)orderNumber;
        this.displayImage = displayImage;
        this.combineItem = combineItem;
    }

    public void DisplayItem()
    {
        inventory.GetComponent<InventoryManager>().itemDisplayer.SetActive(true);
        inventory.GetComponent<InventoryManager>().itemDisplayer.GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory/" + displayImage);
    }

    public void Combine()
    {
        if (inventory.GetComponent<InventoryManager>().previousSelectedSlot.GetComponent<Slot>().combineItem == 
            this.gameObject.GetComponent<Slot>().combineItem && this.gameObject.GetComponent<Slot>().combineItem! == "")
        {
            Debug.Log("Combine");
            var combinedItem = Instantiate(Resources.Load<GameObject>("CombineItems/" + combineItem));
            combinedItem.GetComponent<PickUp>().ItemPickUp();

            inventory.GetComponent<InventoryManager>().previousSelectedSlot.GetComponent<Slot>().ClearSlot();
            ClearSlot();
        }
    }

    public void ClearSlot()
    {
        ItemProperty = Slot.Property.empty;
        displayImage = "";
        combineItem = "";
        transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory/Empty");
    }
}
