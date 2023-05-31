using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleZoom : MonoBehaviour, IInteractable
{
    public GameObject[] changeview;
    public GameObject cameraNewPos;
    public string posName;
    public GameObject[] zoomIN;

    public void Interact(DisplayImage currentDisplay)
    {
        if (currentDisplay.CurrentState == DisplayImage.State.zoom)
        {
            foreach (GameObject obj in zoomIN)
            {

                if (obj.name == "zoomInRotate")
                {
                    if (cameraNewPos.name == posName)
                    {
                        Camera.main.transform.position = cameraNewPos.transform.position;
                        Debug.Log("double zoomed");
                    }

                }
                obj.layer = 2;
            }
            currentDisplay.CurrentState = DisplayImage.State.doubleZoom;
        }
    }
}
