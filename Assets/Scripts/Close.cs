using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour, IInteractable
{
    public GameObject closeItem;
    public void Interact(DisplayImage currentDisplay)
    {
        Debug.Log("hits");
        closeItem.SetActive(false);
    }
}
