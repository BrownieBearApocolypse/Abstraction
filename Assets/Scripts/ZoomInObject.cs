using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomInObject : MonoBehaviour, IInteractable
{
    public GameObject[] changeview;
    public GameObject[] cameraNewPos;

    public void Interact(DisplayImage currentDisplay)
    {
        currentDisplay.CurrentState = DisplayImage.State.zoom;
        foreach (var change in changeview)
        {
            GetComponent<ChangeView>().enabled = false;
        }
        for (int i = 0; i < cameraNewPos.Length; i++)
        {
            if (cameraNewPos[i].name == currentDisplay.GetComponent<SpriteRenderer>().sprite.name)
            {
                
            }
            else if (cameraNewPos[i].name == currentDisplay.GetComponent<SpriteRenderer>().sprite.name)
            {
               
            }
            else
            {

            }
        }
    }

    
}
