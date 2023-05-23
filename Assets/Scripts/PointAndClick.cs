using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour
{
   private DisplayImage currentDisplay;
   

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();       
    }

    void Update()
   {
        if(Input.GetMouseButtonDown(0))
        {
            //Vector3 mousePosition = Input.mousePosition;
            //mousePosition.z = Camera.main.nearClipPlane;
            //Vector3 rayPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            ////Vector3 rayPosition = new Vector3(6.79f, 9.21f, 2.81f);
            //RaycastHit hit;
            //
            //
            //if (Physics.Raycast(rayPosition, out hit, 100))
            //{
            //    Debug.Log("I'm here :D :)");
            //    if (hit.transform.CompareTag("Interactable"))
            //    {
            //        Debug.Log("and now I'm here :D :)");
            //        hit.transform.GetComponent<IInteractable>().Interact(currentDisplay);
            //    }
            //}


            // rayPosition, Vector3.zero, 100)
             //Vector3 rayPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // RaycastHit2D hit = Physics2D.Raycast(rayPosition, Vector3.zero, 100);
            /*this is the stop point*/ //Debug.Log(Physics2D.Raycast(rayPosition, Vector3.zero, 100));
                                       //RaycastHit hit;
                                       //if (Physics.Raycast(rayPosition, out hit, 100))
                                       //{


            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //Debug.DrawRay(ray, Camera.main.transform.forward * 10000f, Color.red, 4.0f);
            if (Physics.Raycast(ray, out hit))
            {

                if (hit.transform.tag == "Interactable")
                {
                   // Debug.Log(hit && hit.transform.tag == "Interactable");
                    hit.transform.GetComponent<IInteractable>().Interact(currentDisplay);
                    Debug.Log("I'm in the middle :)");
                }
                Debug.Log("I'm at the end:D");

                Debug.Log(gameObject.name);

            }
                // hit = Physics.Raycast(rayPosition, out hit, 100);
                //Debug.DrawRay(rayPosition, Camera.main.transform.forward * 10000f, Color.red, 4.0f);
            
             //    if (hit.transform.tag == "Interactable")
             //    {
             //        Debug.Log(hit && hit.transform.tag == "Interactable");
             //        hit.transform.GetComponent<IInteractable>().Interact(currentDisplay);
             //        Debug.Log("and now I'm here :D :)");
             //    }
                 
             //}

      
        }
    }
}
