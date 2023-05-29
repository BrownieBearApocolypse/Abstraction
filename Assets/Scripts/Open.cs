using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour, IInteractable
{
    public GameObject OpenItem;
    
    private PuzzleManager manager;

    public void Start()
    {
        manager = GameObject.Find("script holder").GetComponent<PuzzleManager>();
    }

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
