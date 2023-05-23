using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    private DisplayImage currentDisplay;

    public Button[] buttons;

    private float initialCameraSize;
    private Vector3 initialCameraPosition;
    
    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();
        initialCameraSize = Camera.main.orthographicSize;
        initialCameraPosition = Camera.main.transform.position;
    }

    public void OnDoorClick()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall + 1;
    }

    public void OnCurtainClick()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall + 2;
    }

    public void OnWindowClick()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall + 3;
    }

    public void OnTreeClick()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall + 4;
    }

    public void OnClickReturn()
    {
        if (currentDisplay.CurrentState == DisplayImage.State.zoom)
        {
            GameObject.Find("displayImage").GetComponent<DisplayImage>().CurrentState = DisplayImage.State.normal;
            var zoomInObjects = FindObjectsOfType<ZoomInObject>();
            foreach(var zoomInObject in zoomInObjects)
            {
                zoomInObject.gameObject.layer = 0;
            }

            Camera.main.orthographicSize = initialCameraSize;
            Camera.main.transform.position = initialCameraPosition; 
        }
        else
        {
            currentDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Wall" + currentDisplay.CurrentWall);
            currentDisplay.CurrentState = DisplayImage.State.normal;           
        }       
        
    }
    
}
