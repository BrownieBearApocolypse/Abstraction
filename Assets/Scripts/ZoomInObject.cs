using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class ZoomInObject : MonoBehaviour, IInteractable
{
    public GameObject[] changeview;
    public GameObject cameraNewPos;
    public string posName;
    public GameObject[] zoom;

    public void Interact(DisplayImage currentDisplay)
    {
        currentDisplay.CurrentState = DisplayImage.State.zoom;
        foreach (var change in changeview)
        {
            change.layer = 2;
        }       
        if (cameraNewPos.name == posName)
        {
            Camera.main.transform.position = cameraNewPos.transform.position;   
        }
        foreach (var obj in zoom)
        {
            obj.layer = 2;
        }
            
    }

    
}
