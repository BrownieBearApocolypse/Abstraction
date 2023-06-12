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
        if (OpenItem.activeInHierarchy == false)
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            OpenItem.SetActive(true);
        }
    }
}
