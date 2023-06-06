using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Curtain : MonoBehaviour, IInteractable
{
    public string ScissorItem;
    public GameObject mainCurtain;
    public GameObject bottomCurtain;
    private GameObject inventory;
    private PuzzleManager manager;

    public void Start()
    {
        inventory = GameObject.Find("Inventory");
        manager = GameObject.Find("script holder").GetComponent<PuzzleManager>();
    }

    public void Interact(DisplayImage currentDisplay)
    {
        Slot currentSlot = inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>();
        if (currentSlot.ItemProperty == Slot.Property.usable && inventory.GetComponent<InventoryManager>().currentSelectedSlot.transform.GetChild(0).GetComponent<Image>().sprite.name == ScissorItem)
        {
            mainCurtain.GetComponent<SpriteRenderer>().enabled = false;
            manager.CurtainIsCompleted = true;
            Destroy(gameObject);
        }
    }
}
