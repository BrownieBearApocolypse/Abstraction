using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VendingMachine : MonoBehaviour, IInteractable
{
    private GameObject inventory;
    public string money;
    public string gift;
    public float delay = 0f;
    public GameObject mouth;


    public void Start()
    {
        inventory = GameObject.Find("Inventory");
    }

    public void Interact(DisplayImage currentDisplay)
    {
        Slot slot = inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>();
        if (currentDisplay.CurrentState == DisplayImage.State.zoom && slot.ItemProperty == Slot.Property.usable 
            && inventory.GetComponent<InventoryManager>().currentSelectedSlot.transform.GetChild(0).GetComponent<Image>().sprite.name == money)
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>().ClearSlot();
            mouth.gameObject.GetComponent<Animator>().SetTrigger("Clicked");
            Instantiate(Resources.Load<GameObject>("CombineItems/" + gift));
        }
    }

}
