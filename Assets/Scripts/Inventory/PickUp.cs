using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    //goes on item
    public string DisplaySprite;
    public enum Property { usable, displayable };

    private GameObject InventorySlots;

    public string CombinationItem;

    public Property itemProperty;
    public string DisplayImage;

    public void Interact(DisplayImage currentImage)
    {
        ItemPickUp();
    }

    void Start()
    {
        
    }

    public void ItemPickUp()
    {
        InventorySlots = GameObject.Find("Inventory");

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
