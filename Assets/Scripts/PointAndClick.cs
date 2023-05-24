using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour
{
   private DisplayImage currentDisplay;
   

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();
        GameObject.Find("displayImage").GetComponent<DisplayImage>().CurrentState = DisplayImage.State.normal;
    }

    void Update()
   {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
          
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Interactable")
                {                   
                    hit.transform.GetComponent<IInteractable>().Interact(currentDisplay);
                }
            
            }
                
        }
    }
}
