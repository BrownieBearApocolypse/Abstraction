using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour//, IInteractable
{
   void Update()
   {
        if(Input.GetMouseButtonDown(0))
        {
            /*Vector3 rayPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit hit = Physics.Raycast(rayPosition, Vector3.zero, 100);

            if(hit && hit.transform.tag == "Item")
            {
                hit.transform.GetComponent<IInteractable>().Interact();
            }*/
        }
   }
}
