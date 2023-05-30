using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class VendingMachine : MonoBehaviour, IInteractable
{

    private PuzzleManager manager;
    private GameObject inventory;
    public string Scroll;
    public float delay = 0f;

    public void Start()
    {
        inventory = GameObject.Find("Inventory");
        manager = GameObject.Find("script holder").GetComponent<PuzzleManager>();
    }

    public void Interact(DisplayImage currentDisplay)
    {
        throw new System.NotImplementedException();
    }
}
