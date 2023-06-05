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
    private PickUp pickUp;

    public void Start()
    {
        inventory = GameObject.Find("Inventory");
        pickUp = GameObject.Find("script holder").GetComponent<PickUp>();
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
        gameObject.transform.GetChild(0).GetComponent<Image>().color = pickUp.newcolor;
    }

    public void DisplayItem()
    {
        InventoryManager inventoryManager = inventory.GetComponent<InventoryManager>();
        inventoryManager.itemDisplayer.SetActive(true);
        inventoryManager.itemDisplayer.GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory/" + displayImage);
    }

    public void Combine()
    {
        Slot previousSlot = inventory.GetComponent<InventoryManager>().previousSelectedSlot.GetComponent<Slot>();
        Slot currentSlot = inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>();

        if (previousSlot != null && previousSlot.combineItem == combineItem && currentSlot.combineItem == combineItem)
        {            
            var combinedItem = Instantiate(Resources.Load<GameObject>("CombineItems/" + combineItem));
            combinedItem.gameObject.GetComponent<PickUp>().ItemPickUp();
            Debug.Log("Combine");
            previousSlot.ClearSlot();
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
