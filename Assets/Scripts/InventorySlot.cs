using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IInteractable
{
    public GameObject DisplayObject;

    public void Interact(DisplayImage currentdisplay)
    {
        DisplayObject.SetActive(true);
    }
}
