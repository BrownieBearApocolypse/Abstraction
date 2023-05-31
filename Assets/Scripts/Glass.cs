using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Glass : MonoBehaviour, IInteractable
{
    public string LeverItem;
    private GameObject inventory;
    private PuzzleManager manager;
    public string shards;
    public float delay = 1f;


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
            inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>().ClearSlot();
            Destroy(gameObject /*this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay*/);
            //this.gameObject.GetComponent<Animator>().SetTrigger("Clicked");
            Instantiate(Resources.Load<GameObject>("CombineItems/" + shards));
        }
    }
}
