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
        if (inventory.GetComponent<InventoryManager>().currentSelectedSlot.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem)
        {          
            inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>().ClearSlot();
            Open.SetActive(true);
            MainOpen.SetActive(false);
            this.gameObject.SetActive(false);
            MainClosed.SetActive(false);
        }
        
    }
}
