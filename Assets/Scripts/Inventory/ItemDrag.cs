using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    
    [Header("UI")]
    public Image image;
    public Text countText;
    [HideInInspector] public Transform parentAfterDrag;
    [HideInInspector] public int count;
    [HideInInspector] public Item item;
      
    public void InitialiseItem(Item newItem)
    {
        //make new item
        item = newItem;
        image.sprite = newItem.image;
        RefreshCount();
    }

    public void RefreshCount()
    {
        //update text number
        countText.text = count.ToString();
        bool textActive = count > 1;
        countText.gameObject.SetActive(textActive);
    }

   public void OnBeginDrag(PointerEventData eventData)
   {
        //starts the drag on mouse click
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
   }

    public void OnDrag(PointerEventData eventData)
    {
        //continues the drag
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //ends the drag
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }
}
