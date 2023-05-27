using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    //goes on item
    public string DisplaySprite;
    public enum Property { usable, displayable};

    private GameObject InventorySlots;

    public Property itemProperty;

    public void Interact(DisplayImage currentImage)
    {
        ItemPickUp();
    }

    void Start()
    {
        InventorySlots = GameObject.Find("Inventory");
    }

    void ItemPickUp()
    {
        foreach (Transform slot in InventorySlots.transform)
        {
            if(slot.transform.GetChild(0).GetComponent<Image>().sprite.name == "Empty")
            {
                slot.transform.GetChild(0).GetComponent<Image>().sprite =
                    Resources.Load<Sprite>("Inventory/" + DisplaySprite);
                slot.GetComponent<Slot>().AssignProperty((int)itemProperty);
                Destroy(gameObject);
                break;
            }
        }
    }

}
