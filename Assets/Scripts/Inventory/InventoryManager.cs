using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public int maxStackedItems = 15;
    public GameObject itemPrefab;
    public InventorySlot[] inventorySlots;    

    int selectedSlot = -1;

    void ChangeSelectedSlot(int newValue)
    {
        if (selectedSlot >= 0)
        {
            inventorySlots[selectedSlot].Deselect();
        }     
        inventorySlots[newValue].Select();
        selectedSlot = newValue;
    }    

    public bool AddItem(Item item)
    {

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
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            InventorySlot slot = inventorySlots[i];
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
        GameObject newItemGo = Instantiate(itemPrefab, slot.transform);
        ItemDrag inventoryItem = newItemGo.GetComponent<ItemDrag>();
        inventoryItem.InitialiseItem(item);

    }
}
