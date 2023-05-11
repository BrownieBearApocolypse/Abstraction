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
    public Camera wallCam;
    public Camera cupboardCam;

    public Button backButton;
    public Button clockButton;
    public Button treeButton;
    public Button windowButton;
    public Button wallButton;
    public Button cupboardButton;

    public void Start()
   {
        mainCam.enabled = true;
        clockCam.enabled = false;
        treeCam.enabled = false;
        windowCam.enabled = false;
        wallCam.enabled = false;
        cupboardCam.enabled = false;

        cupboardButton.enabled = true;
        clockButton.enabled = true;
        treeButton.enabled = true;
        windowButton.enabled = true;
        wallButton.enabled = true;
        backButton.enabled = false;
    }

    public void ClockCam()
    {
        mainCam.enabled = false;
        clockCam.enabled = true;
        treeCam.enabled = false;
        windowCam.enabled = false;
        wallCam.enabled = false;
        cupboardCam.enabled = false;

        cupboardButton.enabled = false;
        clockButton.enabled = false;
        treeButton.enabled = false;
        windowButton.enabled = false;
        wallButton.enabled = false;
        backButton.enabled = true;
    }

    public void TreeCam()
    {
        mainCam.enabled = false;
        clockCam.enabled = false;
        treeCam.enabled = true;
        windowCam.enabled = false;
        wallCam.enabled = false;
        cupboardCam.enabled = false;

        cupboardButton.enabled = false;
        clockButton.enabled = false;
        treeButton.enabled = false;
        windowButton.enabled = false;
        wallButton.enabled = false;
        backButton.enabled = true;
    }

    public void WindowCam()
    {
        mainCam.enabled = false;
        clockCam.enabled = false;
        treeCam.enabled = false;
        windowCam.enabled = true;
        wallCam.enabled = false;
        cupboardCam.enabled = false;

        cupboardButton.enabled = false;
        clockButton.enabled = false;
        treeButton.enabled = false;
        windowButton.enabled = false;
        wallButton.enabled = false;
        backButton.enabled = true;
    }

    public void WallCam()
    {
        mainCam.enabled = false;
        clockCam.enabled = false;
        treeCam.enabled = false;
        windowCam.enabled = false;
        wallCam.enabled = true;
        cupboardCam.enabled = false;

        cupboardButton.enabled = false;
        clockButton.enabled = false;
        treeButton.enabled = false;
        windowButton.enabled = false;
        wallButton.enabled = false;
        backButton.enabled = true;
    }

    public void CupboardCam()
    {
        mainCam.enabled = false;
        clockCam.enabled = false;
        treeCam.enabled = false;
        windowCam.enabled = false;
        wallCam.enabled = false;
        cupboardCam.enabled = true;

        cupboardButton.enabled = false;
        clockButton.enabled = false;
        treeButton.enabled = false;
        windowButton.enabled = false;
        wallButton.enabled = false;
        backButton.enabled = true;
    }

    public void Back()
    {
        mainCam.enabled = true;
        clockCam.enabled = false;
        treeCam.enabled = false;
        windowCam.enabled = false;
        wallCam.enabled = false;
        cupboardCam.enabled = false;

        cupboardButton.enabled = true;
        clockButton.enabled = true;
        treeButton.enabled = true;
        windowButton.enabled = true;
        wallButton.enabled = true;
        backButton.enabled = false;
    }
}
