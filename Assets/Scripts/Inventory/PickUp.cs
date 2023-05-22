using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public string DisplaySprite;

    private GameObject InventorySlots;

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
            }
        }
    }

}
