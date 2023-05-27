using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour, IInteractable
{
    public GameObject OpenItem;
    
    public void Interact(DisplayImage currentDisplay)
    {
        if (OpenItem.activeInHierarchy == false && currentDisplay.CurrentState == DisplayImage.State.zoom)
        {
            OpenItem.SetActive(true);
        }
        else
        {
            OpenItem.SetActive(false);
        }
    }
}
