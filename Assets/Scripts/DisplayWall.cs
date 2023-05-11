using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class DisplayWall : MonoBehaviour
{
    public Camera mainCam;
    public Camera clockCam;
    public Camera treeCam;
    public Camera windowCam;
    public Camera wallCam;
    public Camera cupboardCam;

   public void Start()
   {
        mainCam.enabled = true;
        clockCam.enabled = false;
        treeCam.enabled = false;
        windowCam.enabled = false;
        wallCam.enabled = false;
        cupboardCam.enabled = false;
   }

    public void ClockCam()
    {
        mainCam.enabled = false;
        clockCam.enabled = true;
        treeCam.enabled = false;
        windowCam.enabled = false;
        wallCam.enabled = false;
        cupboardCam.enabled = false;
    }

    public void TreeCam()
    {
        mainCam.enabled = false;
        clockCam.enabled = false;
        treeCam.enabled = true;
        windowCam.enabled = false;
        wallCam.enabled = false;
        cupboardCam.enabled = false;
    }

    public void WindowCam()
    {
        mainCam.enabled = false;
        clockCam.enabled = false;
        treeCam.enabled = false;
        windowCam.enabled = true;
        wallCam.enabled = false;
        cupboardCam.enabled = false;
    }

    public void WallCam()
    {
        mainCam.enabled = false;
        clockCam.enabled = false;
        treeCam.enabled = false;
        windowCam.enabled = false;
        wallCam.enabled = true;
        cupboardCam.enabled = false;
    }

    public void CupboardCam()
    {
        mainCam.enabled = false;
        clockCam.enabled = false;
        treeCam.enabled = false;
        windowCam.enabled = false;
        wallCam.enabled = false;
        cupboardCam.enabled = true;
    }

    public void Back()
    {
        mainCam.enabled = true;
        clockCam.enabled = false;
        treeCam.enabled = false;
        windowCam.enabled = false;
        wallCam.enabled = false;
        cupboardCam.enabled = false;
    }
}
