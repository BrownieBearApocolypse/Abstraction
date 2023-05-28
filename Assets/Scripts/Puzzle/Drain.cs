using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Drain : MonoBehaviour, IInteractable
{
    public string LeverItem;
    private GameObject inventory;
    public void Interact(DisplayImage currentDisplay)
    {
        if (inventory.GetComponent<InventoryManager>().currentSelectedSlot.transform.GetChild(0).GetComponent<Image>().sprite.name == LeverItem)
        {
            inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>().ClearSlot();
            Destroy(this);            
        }
    }
}
