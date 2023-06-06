using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.PlayerSettings;

public class Clock : MonoBehaviour, IInteractable
{
    private float limit = 1.2f;
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
        if (currentSlot != null && currentSlot.ItemProperty == Slot.Property.usable && currentDisplay.CurrentState == DisplayImage.State.zoom 
            && inventory.GetComponent<InventoryManager>().currentSelectedSlot.transform.GetChild(0).GetComponent<Image>().sprite.name == ScrewDriver)
        {            
            currentSlot.ClearSlot();
            manager.ClockIsCompleted = true;
            Destroy(gameObject, limit);
            Invoke("MakeThing", 1);

        }
    }
    
    public void MakeThing()
    {
        Debug.Log("IGotHere");
        Instantiate(Resources.Load<GameObject>("CombineItems/" + gift));
    }
}
    
