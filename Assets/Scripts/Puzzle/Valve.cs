using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Valve : MonoBehaviour, IInteractable
{
    private PuzzleManager manager;
    private GameObject inventory;
    public string valveHandle;
    public float delay = 0f;

    public void Start()
    {
        inventory = GameObject.Find("Inventory");
        manager = GameObject.Find("script holder").GetComponent<PuzzleManager>();
    }

    public void Interact(DisplayImage currentDisplay)
    {
        manager.ValveIsCompleted = true;

        Slot currentSlot = inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>();
        if (currentSlot != null && currentSlot.ItemProperty == Slot.Property.usable && inventory.GetComponent<InventoryManager>().currentSelectedSlot.transform.GetChild(0).GetComponent<Image>().sprite.name == valveHandle)
        {
            inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>().ClearSlot();
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Inventory/" + valveHandle);
            //gameObject.GetComponent<Animator>().SetTrigger("Not here yet");;
            GameObject.Find("shelf").GetComponent<Animator>().SetTrigger("Clicked");
        }

        //REMINDER; TO TRICK PLAYER INTO MELTING CLOCK HAVE A SHEET OF PAPER THEY FIND WITH PERSISTANCE OF MEMORY ON IT ZOOMED IN ON THE MELTED CLOCK
        //this has kind become my notes spot
        //
    }
}
