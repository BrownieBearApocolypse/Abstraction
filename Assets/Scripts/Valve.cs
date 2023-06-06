using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Valve : MonoBehaviour, IInteractable
{
    private PuzzleManager manager;
    private GameObject inventory;
    public string valveHandle;
    public float delay = 1f;

    public void Start()
    {
        inventory = GameObject.Find("Inventory");
        manager = GameObject.Find("script holder").GetComponent<PuzzleManager>();
    }

    public void Interact(DisplayImage currentDisplay)
    {
        Debug.Log("AH");
        manager.ValveIsCompleted = true;
        var shelf = GameObject.Find("shelf");
        Slot currentSlot = inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>();
        if (currentSlot.ItemProperty == Slot.Property.usable && inventory.GetComponent<InventoryManager>().currentSelectedSlot.transform.GetChild(0).GetComponent<Image>().sprite.name == valveHandle)
        {
            inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>().ClearSlot();
            var valvE = Instantiate(Resources.Load<GameObject>("Prefabs/Valve"));
            Destroy(gameObject, delay);
            Destroy(shelf, delay);
            Destroy(valvE, delay);
        }

        //REMINDER; TO TRICK PLAYER INTO MELTING CLOCK HAVE A SHEET OF PAPER THEY FIND WITH PERSISTANCE OF MEMORY ON IT ZOOMED IN ON THE MELTED CLOCK
        //this has kind become my notes spot
        //
    }
}
