using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour, IInteractable
{
    private PuzzleManager manager;
    private GameObject inventory;
    public string ScrewDriver;
    public string gift;

    public void Start()
    {
        manager = GameObject.Find("script holder").GetComponent<PuzzleManager>();
        inventory = GameObject.Find("Inventory");
    }

    public void Interact(DisplayImage currentDisplay)
    {
        Slot currentSlot = inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>();
        if (currentSlot != null && currentSlot.ItemProperty == Slot.Property.usable && 
            inventory.GetComponent<InventoryManager>().currentSelectedSlot.transform.GetChild(0).GetComponent<Image>().sprite.name == ScrewDriver)
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            currentSlot.ClearSlot();
            manager.ClockIsCompleted = true;
            this.gameObject.GetComponent<Animator>().SetTrigger("Clicked");
        }
    }

    public void BuhBye()
    {
        Destroy(gameObject);
    }    
    
    public void MakeThing()
    {
        Instantiate(Resources.Load<GameObject>("CombineItems/" + gift));
    }
}
    
