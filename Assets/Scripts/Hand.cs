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

        if (currentSlot.ItemProperty == Slot.Property.usable 
            && inventory.GetComponent<InventoryManager>().currentSelectedSlot.transform.GetChild(0).GetComponent<Image>().sprite.name == Pot)
        {
            currentSlot.ClearSlot();
            manager.WindowIsCompleted = true;
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.34f, 0.5f, 0.8f, 1f);
            Application.Quit();
            Debug.Log("done, you Did It");
        }
    }
}
