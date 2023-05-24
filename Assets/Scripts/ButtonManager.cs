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

    private float initialCameraSize;
    private Vector3 initialCameraPosition;
    
    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();
        objectManager = GameObject.Find("script holder").GetComponent<ObjectManager>();
        initialCameraSize = Camera.main.orthographicSize;
        initialCameraPosition = Camera.main.transform.position;
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
