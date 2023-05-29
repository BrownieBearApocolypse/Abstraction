using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour, IInteractable
{
    public float delay = 0f;
    private PuzzleManager manager;
    private GameObject inventory;
    public string ScrewDriver;

    public void Start()
    {
        manager = GameObject.Find("script holder").GetComponent<PuzzleManager>();
        inventory = GameObject.Find("Inventory");
    }

    public void Interact(DisplayImage currentDisplay)
    {
        Slot currentSlot = inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>();
        if (currentSlot != null && currentSlot.ItemProperty == Slot.Property.usable && currentDisplay.CurrentState == DisplayImage.State.zoom && inventory.GetComponent<InventoryManager>().currentSelectedSlot.transform.GetChild(0).GetComponent<Image>().sprite.name == ScrewDriver)
        {
            Debug.Log("I have been CLicked");
            this.gameObject.GetComponent<Animator>().SetTrigger("Clicked");
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
            //Instantiate(Resources.Load<GameObject>("I haven't made it yet"));
            manager.ClockIsCompleted = true;
        }
    }
}
    
