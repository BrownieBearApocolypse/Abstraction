using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class DisplayWall : MonoBehaviour
{
    public GameObject main;
    public GameObject clock;
    public GameObject tree;
    public GameObject window;
    public GameObject wall1;
    public GameObject cupboard;
    public GameObject door;
    public GameObject wall2;

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
        main.SetActive(true);
        clock.SetActive(false);
        cupboard.SetActive(false);
        tree.SetActive(false);
        wall1.SetActive(false);
        wall2.SetActive(false);
        door.SetActive(false);
        window.SetActive(false);

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
        main.SetActive(false);
        clock.SetActive(true);
        cupboard.SetActive(false);
        tree.SetActive(false);
        wall1.SetActive(false);
        wall2.SetActive(false);
        door.SetActive(false);
        window.SetActive(false);


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
        main.SetActive(false);
        clock.SetActive(false);
        cupboard.SetActive(false);
        tree.SetActive(true);
        wall1.SetActive(false);
        wall2.SetActive(false);
        door.SetActive(false);
        window.SetActive(false);


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
        main.SetActive(false);
        clock.SetActive(false);
        cupboard.SetActive(false);
        tree.SetActive(false);
        wall1.SetActive(false);
        wall2.SetActive(false);
        door.SetActive(false);
        window.SetActive(true);


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
        main.SetActive(false);
        clock.SetActive(false);
        cupboard.SetActive(false);
        tree.SetActive(false);
        wall1.SetActive(true);
        wall2.SetActive(false);
        door.SetActive(false);
        window.SetActive(false);


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
        main.SetActive(false);
        clock.SetActive(false);
        cupboard.SetActive(true);
        tree.SetActive(false);
        wall1.SetActive(false);
        wall2.SetActive(false);
        door.SetActive(false);
        window.SetActive(false);


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
        main.SetActive(false);
        clock.SetActive(false);
        cupboard.SetActive(false);
        tree.SetActive(false);
        wall1.SetActive(false);
        wall2.SetActive(false);
        door.SetActive(true);
        window.SetActive(false);


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
        main.SetActive(false);
        clock.SetActive(false);
        cupboard.SetActive(false);
        tree.SetActive(false);
        wall1.SetActive(false);
        wall2.SetActive(true);
        door.SetActive(false);
        window.SetActive(false);


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
        main.SetActive(true);
        clock.SetActive(false);
        cupboard.SetActive(false);
        tree.SetActive(false);
        wall1.SetActive(false);
        wall2.SetActive(false);
        door.SetActive(false);
        window.SetActive(false);


        cupboardButton.enabled = true;
        clockButton.enabled = true;
        treeButton.enabled = true;
        windowButton.enabled = true;
        wall1Button.enabled = true;
        doorButton.enabled = false;
        wall2Button.enabled = false;      
    }
}
