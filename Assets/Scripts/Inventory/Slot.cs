using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IPointerClickHandler
{
    private GameObject inventory;
    public enum Property { usable, displayable };
    public Property ItemProperty { get; set; }

    public void Start()
    {
        inventory = GameObject.Find("Inventory");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        inventory.GetComponent<InventoryManager>().previousSelectedSlot = inventory.GetComponent<InventoryManager>().currentSelectedSlot;
        inventory.GetComponent<InventoryManager>().currentSelectedSlot = this.gameObject;
    }

    public void AssignProperty(int orderNumber)
    {
        ItemProperty = (Property)orderNumber;
    }
}
