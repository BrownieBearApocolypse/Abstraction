using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeView : MonoBehaviour, IInteractable
{
    //goes on box that changes the view
    public string ViewName;

    public void Interact(DisplayImage currentDisplay)
    {
        Debug.Log("ClickView");
        currentDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/" + ViewName);
        Debug.Log(currentDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/" + ViewName));
        currentDisplay.CurrentState = DisplayImage.State.ChangedView;

    }
}
