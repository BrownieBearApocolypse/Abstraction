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
    public GameObject mainCamera;

    void Start()
    {
        mainCamera = GameObject.Find("MAINCAM");
    }
    public void Interact(DisplayImage currentDisplay)
    {
        for (int i = 0; i < zoomIN.Length; i++)
        {
            GameObject obj = zoomIN[i];
            currentDisplay.CurrentState = DisplayImage.State.zoom;
            foreach (var change in changeview)
            {
                change.layer = 2;
            }
            if (cameraNewPos.name == posName)
            {                
                mainCamera.transform.position = cameraNewPos.transform.position;
                Debug.Log("FuckMe" + Camera.main.transform.position);
            }
        }
    }

    
}
