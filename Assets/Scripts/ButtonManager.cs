using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    private DisplayImage currentDisplay;

    private float initialCameraSize;
    private Vector3 initialCameraPosition;
    
    void Start()
    {
      currentDisplay = GameObject.Find("MAIN");
        initialCameraSize = Camera.main.orthographicSize;
        initialCameraPosition = Camera.main.transform.position;
    }

    public void OnClickZoomReturn()
    {
        GameObject.Find("script holder").GetComponent<DisplayImage>.CurrentState = DisplayImage.State.normal;
        var zoomInObjects = FindObjectsOfType<ZoomInObject>();
        foreach(var zoomInObject in zoomInObjects)
        {
            zoomInObject.gameObject.layer = 0;
        }

        Camera.main.orthographicSize = initialCameraSize;
        Camera.main.transform.position = initialCameraPosition;
    }
    
    //this top bit needs to become (when click here (raycast), swap to the correct screen
    public void ClockCam()
    {
      //currentDisplay.CurrentWall = GameObject.Find("CLOCK").SetActive(true);
    }

    public void TreeCam()
    {
      //currentDisplay.CurrentWall = GameObject.Find("TREE").SetActive(true);
    }

    public void WindowCam()
    {
      //currentDisplay.CurrentWall = GameObject.Find("WINDOW").SetActive(true);
    }

    public void Wall1Cam()
    {
      //currentDisplay.CurrentWall = GameObject.Find("WALL1").SetActive(true);
    }

    public void CupboardCam()
    {
      //currentDisplay.CurrentWall = GameObject.Find("CUPBOARD").SetActive(true);
    }

    public void DoorCam()
    {
      //currentDisplay.CurrentWall = GameObject.Find("DOOR").SetActive(true);
    }

    public void Wall2Cam()
    {
      //currentDisplay.CurrentWall = GameObject.Find("WALL2").SetActive(true);
    }

   /* public void Back()
    {
        cupboardButton.enabled = true;
        clockButton.enabled = true;
        treeButton.enabled = true;
        windowButton.enabled = true;
        wall1Button.enabled = true;
        doorButton.enabled = true;
        wall2Button.enabled = true;      
    }*/
}
