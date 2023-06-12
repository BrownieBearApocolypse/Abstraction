using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Glass : MonoBehaviour, IInteractable
{
    public string LeverItem;
    private GameObject inventory;
    private PuzzleManager manager;
    public string shards;


    public void Start()
    {
        inventory = GameObject.Find("Inventory");
        manager = GameObject.Find("script holder").GetComponent<PuzzleManager>();
    }

    public void Interact(DisplayImage currentDisplay)
    {
        Slot currentSlot = inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>();
        if (currentSlot != null && currentSlot.ItemProperty == Slot.Property.usable 
            && inventory.GetComponent<InventoryManager>().currentSelectedSlot.transform.GetChild(0).GetComponent<Image>().sprite.name == LeverItem)
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            Destroy(gameObject);
            Instantiate(Resources.Load<GameObject>("CombineItems/" + shards));
        }
    }
}
