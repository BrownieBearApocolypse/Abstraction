using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour, IInteractable
{
    //goes on item
    public string DisplaySprite;
    public enum Property { usable, displayable };
    private GameObject InventorySlots;
    public string CombinationItem;    
    public string DisplayImage;
    public Property itemProperty;
    public void Interact(DisplayImage currentImage)
    {
        ItemPickUp();
    }

    public void Start()
    {
        InventorySlots = GameObject.Find("Inventory");
    }

    public void ItemPickUp()
    {
        foreach (Transform slot in InventorySlots.transform)
        {
            if(slot.transform.GetChild(0).GetComponent<Image>().sprite.name == "Empty")
            {
                slot.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory/" + DisplaySprite);
                slot.GetComponent<Slot>().AssignProperty((int)itemProperty, DisplayImage, CombinationItem);
                Destroy(gameObject);
                break;
            }
        }
    }

   
}
