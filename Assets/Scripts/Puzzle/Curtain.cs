using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Curtain : MonoBehaviour, IInteractable
{
    public string ScissorItem;
    private GameObject inventory;
    public float delay = 0.1f;
    private PuzzleManager manager;

    public void Start()
    {
        inventory = GameObject.Find("Inventory");
        manager = GameObject.Find("script holder").GetComponent<PuzzleManager>();
    }

    public void Interact(DisplayImage currentDisplay)
    {
        if (inventory.GetComponent<InventoryManager>().currentSelectedSlot.transform.GetChild(0).GetComponent<Image>().sprite.name == ScissorItem)
        {
            this.gameObject.GetComponent<Animator>().SetTrigger("Clicked");
            Destroy(gameObject, GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
        }
    }
}