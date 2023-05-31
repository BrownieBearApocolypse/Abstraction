using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenLock : MonoBehaviour, IInteractable
{
    public string UnlockItem;
    private GameObject inventory;
    public GameObject Open;
    private PuzzleManager manager;

    public void Start()
    {
        inventory = GameObject.Find("Inventory");
        manager = GameObject.Find("script holder").GetComponent<PuzzleManager>();
    }

    public void Interact(DisplayImage currentDisplay)
    {
        Slot currentSlot = inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>();

        if (currentSlot != null && currentSlot.ItemProperty == Slot.Property.usable && currentSlot.combineItem == UnlockItem)
        {
            currentSlot.ClearSlot();
            Destroy(gameObject);
            Open.SetActive(true);
        }
    }

}
