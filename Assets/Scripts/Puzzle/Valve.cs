using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve : MonoBehaviour, IInteractable
{
    private PuzzleManager manager;
    private GameObject inventory;

    public void Start()
    {
        inventory = GameObject.Find("Inventory");
        manager = GameObject.Find("script holder").GetComponent<PuzzleManager>();
    }

    public void Interact(DisplayImage currentDisplay)
    {
        manager.ValveIsCompleted = true;
        //okay so this only becomes active after valve places but activates another animation then destory object, unclogs drain
        //plays 2 animations, one on click and one on state.normal

        //REMINDER; TO TRICK PLAYER INTO MELTING CLOCK HAVE A SHEET OF PAPER THEY FIND WITH PERSISTANCE OF MEMORY ON IT ZOOMED IN ON THE MELTED CLOCK
        //this has kind become my notes spot
        //
    }
}
