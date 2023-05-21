using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class DisplayWall : MonoBehaviour
{
    public Camera mainCam;
    public Camera clockCam;
    public Camera treeCam;
    public Camera windowCam;
    public Camera wall1Cam;
    public Camera cupboardCam;
    public Camera doorCam;
    public Camera wall2Cam;

    public Button backButton;
    public Button clockButton;
    public Button treeButton;
    public Button windowButton;
    public Button wall1Button;
    public Button cupboardButton;
    public Button doorButton;
    public Button wall2Button;

    public void Start()
   {
        mainCam.enabled = true;
        clockCam.enabled = false;
        treeCam.enabled = false;
        windowCam.enabled = false;
        wall1Cam.enabled = false;
        cupboardCam.enabled = false;
        doorCam.enabled = false;
        wall2Cam.enabled = false;

        cupboardButton.enabled = true;
        clockButton.enabled = true;
        treeButton.enabled = true;
        windowButton.enabled = true;
        wall1Button.enabled = true;
        doorButton.enabled = true;
        wall2Button.enabled = true;
    }

    public void ClockCam()
    {
        mainCam.enabled = false;
        clockCam.enabled = true;
        treeCam.enabled = false;
        windowCam.enabled = false;
        wall1Cam.enabled = false;
        cupboardCam.enabled = false;
        doorCam.enabled = false;
        wall2Cam.enabled = false;

        cupboardButton.enabled = false;
        clockButton.enabled = false;
        treeButton.enabled = false;
        windowButton.enabled = false;
        wall1Button.enabled = false;
        doorButton.enabled = false;
        wall2Button.enabled = false;
        backButton.enabled = true;
    }

    public void TreeCam()
    {
        mainCam.enabled = false;
        clockCam.enabled = false;
        treeCam.enabled = true;
        windowCam.enabled = false;
        wall1Cam.enabled = false;
        cupboardCam.enabled = false;
        doorCam.enabled = false;
        wall2Cam.enabled = false;

        cupboardButton.enabled = false;
        clockButton.enabled = false;
        treeButton.enabled = false;
        windowButton.enabled = false;
        wall1Button.enabled = false;
        doorButton.enabled = false;
        wall2Button.enabled = false;
        backButton.enabled = true;
    }

    public void WindowCam()
    {
        mainCam.enabled = false;
        clockCam.enabled = false;
        treeCam.enabled = false;
        windowCam.enabled = true;
        wall1Cam.enabled = false;
        cupboardCam.enabled = false;
        doorCam.enabled = false;
        wall2Cam.enabled = false;

        cupboardButton.enabled = false;
        clockButton.enabled = false;
        treeButton.enabled = false;
        windowButton.enabled = false;
        wall1Button.enabled = false;
        doorButton.enabled = false;
        wall2Button.enabled = false;
        backButton.enabled = true;
    }

    public void Wall1Cam()
    {
        mainCam.enabled = false;
        clockCam.enabled = false;
        treeCam.enabled = false;
        windowCam.enabled = false;
        wall1Cam.enabled = true;
        cupboardCam.enabled = false;
        doorCam.enabled = false;
        wall2Cam.enabled = false;

        cupboardButton.enabled = false;
        clockButton.enabled = false;
        treeButton.enabled = false;
        windowButton.enabled = false;
        wall1Button.enabled = false;
        doorButton.enabled = false;
        wall2Button.enabled = false;
        backButton.enabled = true;
    }

    public void CupboardCam()
    {
        mainCam.enabled = false;
        clockCam.enabled = false;
        treeCam.enabled = false;
        windowCam.enabled = false;
        wall1Cam.enabled = false;
        cupboardCam.enabled = true;
        doorCam.enabled = false;
        wall2Cam.enabled = false;

        cupboardButton.enabled = false;
        clockButton.enabled = false;
        treeButton.enabled = false;
        windowButton.enabled = false;
        wall1Button.enabled = false;
        doorButton.enabled = false;
        wall2Button.enabled = false;
        backButton.enabled = true;
    }

    public void DoorCam()
    {
        mainCam.enabled = false;
        clockCam.enabled = false;
        treeCam.enabled = false;
        windowCam.enabled = false;
        wall1Cam.enabled = false;
        cupboardCam.enabled = false;
        doorCam.enabled = true;
        wall2Cam.enabled = false;

        cupboardButton.enabled = true;
        clockButton.enabled = true;
        treeButton.enabled = true;
        windowButton.enabled = true;
        wall1Button.enabled = true;
        doorButton.enabled = false;
        wall2Button.enabled = false;
    }

    public void Wall2Cam()
    {
        mainCam.enabled = false;
        clockCam.enabled = false;
        treeCam.enabled = false;
        windowCam.enabled = false;
        wall1Cam.enabled = false;
        cupboardCam.enabled = false;
        doorCam.enabled = false;
        wall2Cam.enabled = true;

        cupboardButton.enabled = true;
        clockButton.enabled = true;
        treeButton.enabled = true;
        windowButton.enabled = true;
        wall1Button.enabled = true;
        doorButton.enabled = false;
        wall2Button.enabled = false;
    }

    public void Back()
    {
        mainCam.enabled = true;
        clockCam.enabled = false;
        treeCam.enabled = false;
        windowCam.enabled = false;
        wall1Cam.enabled = false;
        cupboardCam.enabled = false;
        doorCam.enabled = false;
        wall2Cam.enabled = false;

        cupboardButton.enabled = true;
        clockButton.enabled = true;
        treeButton.enabled = true;
        windowButton.enabled = true;
        wall1Button.enabled = true;
        doorButton.enabled = false;
        wall2Button.enabled = false;      
    }
}
