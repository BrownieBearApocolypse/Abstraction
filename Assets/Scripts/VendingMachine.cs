using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VendingMachine : MonoBehaviour, IInteractable
{

    private PuzzleManager manager;
    private GameObject inventory;
    public string money;
    public string gift;
    public float delay = 0f;
    private DisplayImage currentDisplay;


    public void Start()
    {
        inventory = GameObject.Find("Inventory");
        manager = GameObject.Find("script holder").GetComponent<PuzzleManager>();
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();
    }

    public void Interact(DisplayImage currentDisplay)
    {
        Slot slot = inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>();
        if (currentDisplay.CurrentState == DisplayImage.State.zoom && slot.ItemProperty == Slot.Property.usable && inventory.GetComponent<InventoryManager>().currentSelectedSlot.transform.GetChild(0).GetComponent<Image>().sprite.name == money)
        {
            inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>().ClearSlot();
            Instantiate(Resources.Load<GameObject>("CombineItems/" + gift));
            //gameObject.GetComponent<Animator>().SetTrigger("Not here yet");;            
        }
    }
}
