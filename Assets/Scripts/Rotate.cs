using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour, IInteractable
{
    private PuzzleManager manager;

    public void Start()
    {
        manager = GameObject.Find("script holder").GetComponent<PuzzleManager>();
    }
    public void Interact(DisplayImage currentDisplay)
    {
        if (currentDisplay.CurrentState == DisplayImage.State.doubleZoom)
        {
            gameObject.transform.Rotate(0f, 0f, 90f);
        }
        manager.IsRotateCompleted();
    }
}
