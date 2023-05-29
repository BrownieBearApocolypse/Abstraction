using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour, IInteractable
{
    public string UnlockItem;
    private GameObject inventory;
    public GameObject Open;
    public GameObject MainOpen;
    public GameObject MainClosed;

    public void Start()
    {
        inventory = GameObject.Find("Inventory");
    }

    public void Interact(DisplayImage currentDisplay)
    {
        Slot currentSlot = inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>();

        if (currentSlot != null && currentSlot.ItemProperty == Slot.Property.usable && currentSlot.combineItem == UnlockItem)
        {
            currentSlot.ClearSlot();
            Open.SetActive(true);
            MainOpen.SetActive(false);
            gameObject.SetActive(false);
            MainClosed.SetActive(false);
        }
    }

}
