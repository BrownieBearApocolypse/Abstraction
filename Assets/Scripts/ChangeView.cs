using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ChangeView : MonoBehaviour, IInteractable
{
    private ObjectManager objectManager;
    //goes on box that changes the view
    public string ViewName;

    void Start()
    {
        objectManager = GameObject.Find("script holder").GetComponent<ObjectManager>();
    }

    public void Interact(DisplayImage currentDisplay)
    {
        Debug.Log("ClickView");
        currentDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/" + ViewName);        
        currentDisplay.CurrentState = DisplayImage.State.ChangedView;
        objectManager.ManageObject();
    }
}
