using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hand : MonoBehaviour, IInteractable
{
    private PuzzleManager manager;
    public string Pot;
    private GameObject inventory;

    public void Start()
    {
        manager = GameObject.Find("script holder").GetComponent<PuzzleManager>();
        inventory = GameObject.Find("Inventory");
    }

    public void Interact(DisplayImage currentDisplay)
    {
        Slot currentSlot = inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>();

        if (currentSlot != null && currentSlot.ItemProperty == Slot.Property.usable && inventory.GetComponent<InventoryManager>().currentSelectedSlot.transform.GetChild(0).GetComponent<Image>().sprite.name == Pot)
        {
            this.gameObject.GetComponent<Animator>().SetTrigger("Hand It Over");
            currentSlot.ClearSlot();
            manager.WindowIsCompleted = true;
        }
        else
        {
            this.gameObject.GetComponent<Animator>().SetTrigger("Clicked");
        }
    }
}
