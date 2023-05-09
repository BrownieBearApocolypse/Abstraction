using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    public Image image;
    public Color selectedColour, notSelectedColour;
    public bool Selected = false;
    public InventoryManager inventoryManager;

    private void Awake()
    {
        Deselect();

    }

    private void Update()
    {
        if (Selected = false &&Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            inventoryManager.ChangeSelectedSlot();
        }
    }

    public void Select()
    {
        image.color = selectedColour;
    }

    public void Deselect()
    {
        image.color = notSelectedColour;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            ItemDrag draggableItem = dropped.GetComponent<ItemDrag>();
            draggableItem.parentAfterDrag = transform;
        }
       
    }
}
