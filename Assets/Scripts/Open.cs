using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    public GameObject OpenItem;
    private DisplayImage currentImage;

    private void Start()
    {
        currentImage = GameObject.Find("displayImage").GetComponent<DisplayImage>();
    }
    public void Interact(DisplayImage currentDisplay)
    {
        if (OpenItem.activeInHierarchy == false && currentImage.CurrentState == DisplayImage.State.zoom)
        {
            OpenItem.SetActive(true);
        }
        else
        {
            OpenItem.SetActive(false);
        }
    }
}
