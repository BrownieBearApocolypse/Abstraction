using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public DisplayImage currentDisplay;

    public GameObject[] ObjectsToManage;

    // Start is called before the first frame update
    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();
    }

    void Update()
    {
        ManageObject();
    }

    public void ManageObject()
    {
        for (int i = 0; i < ObjectsToManage.Length; i++)
        {
            if (ObjectsToManage[i].name == currentDisplay.GetComponent<SpriteRenderer>().sprite.name)
            {
                ObjectsToManage[i].SetActive(true);
            }
            else
            {
                ObjectsToManage[i].SetActive(false);    
            }
        }
    }
}
