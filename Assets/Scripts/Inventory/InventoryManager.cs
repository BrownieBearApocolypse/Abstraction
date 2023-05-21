using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    public static InventoryManager Instance;
    public int maxStackedItems = 15;
    public GameObject itemPrefab;
    public InventorySlot[] inventorySlots;    

    int selectedSlot = -1;

    public void Awake()
    {
        Instance = this;
    }

    public void ChangeSelectedSlot()
    {
        //change the slot
        /*need to say go to next in array int newValue*/
        
    }    

    public bool AddItem(Item item)
    {
        //track number of items
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            InventorySlot slot = inventorySlots[i];
            ItemDrag itemInSlot = slot.GetComponentInChildren<ItemDrag>();
            if (itemInSlot != null && itemInSlot.item == item && itemInSlot.count < 15 && itemInSlot.item.stackable == true)
            {                
                itemInSlot.count++;
                itemInSlot.RefreshCount();
                return true;
            }
        }
        return false;

        //find any empty spot
        foreach (InventorySlot slot in inventorySlots)
        {
            ItemDrag itemInSlot = slot.GetComponentInChildren<ItemDrag>();
            if (itemInSlot == null)
            {
                SpawnNewItem(item, slot);
                return true;
            }
        }
        return false;
    }

    public void SpawnNewItem(Item item, InventorySlot slot)
    {
        //out item in slot
        GameObject newItemGo = Instantiate(itemPrefab, slot.transform);
        ItemDrag inventoryItem = newItemGo.GetComponent<ItemDrag>();
        inventoryItem.InitialiseItem(item);

    }

    public Item GetSelectedItem(bool use)
    {
        //detect if item used
        InventorySlot slot = inventorySlots[selectedSlot];
        ItemDrag itemInSlot = slot.GetComponentInChildren<ItemDrag>();
        if (itemInSlot != null)
        {
            Item item = itemInSlot.item;
            if (use == true)
            {
                itemInSlot.count--;
                if (itemInSlot.count <= 0)
                {
                    Destroy(itemInSlot.gameObject);
                }
                else
                {
                    itemInSlot.RefreshCount();
                }
            }
            return item;
        }

        return null;
    }
}
