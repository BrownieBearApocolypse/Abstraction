using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    private DisplayImage currentDisplay;
    private ObjectManager objectManager;
    public GameObject[] changeview;
    
    
    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();
        objectManager = GameObject.Find("script holder").GetComponent<ObjectManager>();        
    }
   
    public void OnClickReturn()
    {       
        if (currentDisplay.CurrentState == DisplayImage.State.zoom)
        {
            foreach (var change in changeview)
            {
                GetComponent<ChangeView>().enabled = true;
            }
        }
        else
        {
            currentDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/MAIN");
            currentDisplay.CurrentState = DisplayImage.State.normal;
            objectManager.ManageObject();
        }
        
    }
    
}
