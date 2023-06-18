using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    private DisplayImage currentDisplay;
    private ObjectManager objectManager;
    public GameObject[] changeview;
    public GameObject[] zoom;
    public bool pauseBool = false;


    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();
        objectManager = GameObject.Find("script holder").GetComponent<ObjectManager>();  
    }

    public void Update()
    {
        if (pauseBool == true)
        {

        }
    }

    public void OnClickReturn()
    {
        this.gameObject.GetComponent<AudioSource>().Play();
        if (currentDisplay.CurrentState == DisplayImage.State.zoom)
        {   
            currentDisplay.CurrentState = DisplayImage.State.normal;
            Camera.main.transform.position = new Vector3(0f, 0f, -837.93f);     
            foreach (var obj in zoom)
            {
                obj.layer = 0;
            }
            foreach (var change in changeview)
            {
                change.layer = 0;
            }            
        }
        if (currentDisplay.CurrentState == DisplayImage.State.doubleZoom)
        {
            currentDisplay.CurrentState = DisplayImage.State.normal;
            Camera.main.transform.position = new Vector3(0f, 0f, -837.93f);
            foreach (var obj in zoom)
            {
                obj.layer = 0;
            }
            foreach (var change in changeview)
            {
                change.layer = 0;
            }
        }
        else
        {
            currentDisplay.CurrentState = DisplayImage.State.normal;
            currentDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/MAIN");
            objectManager.ManageObject();
        }
        pauseBool = false;
    }
    
}
