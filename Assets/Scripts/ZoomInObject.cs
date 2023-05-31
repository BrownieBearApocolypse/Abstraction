using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ZoomInObject : MonoBehaviour, IInteractable
{
    public GameObject[] changeview;
    public GameObject cameraNewPos;
    public string posName;
    public GameObject[] zoomIN;
    private GameObject gameObjectToExclude;

    public void Start()
    {
        gameObjectToExclude = GameObject.Find("zoomInRotate");
    }

    public void Interact(DisplayImage currentDisplay)
    {
        foreach (GameObject obj in zoomIN)
        {
            if (obj.name != "zoomInRotate")
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
                foreach (var zooms in zoomIN)
                {
                    if (zooms == gameObjectToExclude)
                        continue;
                    zooms.layer = 2;
                }
            }

        }
    }

    
}
