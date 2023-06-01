using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public bool ClockIsCompleted = false;

    public bool DoorIsCompleted = false;

    public bool ShelfIsCompleted = false;

    public bool SliderIsCompleted = false;

    public bool PotIsCompleted = false;

    public bool WindowIsCompleted = false;

    public bool KineIsCompleted = false;

    public bool DrainIsCompleted = false;

    public bool ValveIsCompleted = false;

    public bool CurtainIsCompleted = false;

    public bool GlassIsCompleted = false;

    public bool FlowerPotIsMade = false;

    public bool VendingIsCompleted = false;

    public bool rotateCompleted = false;





 //private GameObject targetObject;
 //public Vector3 desiredRotation = Vector3.zero;
 //public float rotationTolerance = 0.1f; // Tolerance threshold for rotation comparison
 //
 //private void Start()
 //{
 //    targetObject = GameObject.Find("RotateThisShit");
 //    // Call the CheckChildrenRotation function to check the rotation of all children
 //    bool allChildrenDesiredRotation = CheckChildrenRotation(targetObject.transform);
 //
 //    if (allChildrenDesiredRotation)
 //    {
 //        rotateCompleted = true;
 //        targetObject.transform.GetChild(0).GetComponent<Rotate>().enabled = false;
 //        Debug.Log("All children of " + targetObject.name + " have the desired rotation.");
 //    }
 //    else
 //    {
 //        Debug.Log("Not all children of " + targetObject.name + " have the desired rotation.");
 //    }
 //}
 //
 //private bool CheckChildrenRotation(Transform parent)
 //{
 //    foreach (Transform child in parent)
 //    {
 //        // Check if the child's local rotation is close to the desired rotation
 //        if (Quaternion.Angle(child.localRotation, Quaternion.Euler(desiredRotation)) > rotationTolerance)
 //        {
 //            return false;
 //        }
 //
 //        // Recursive call to check the rotation of the child's children
 //        bool childRotationCheck = CheckChildrenRotation(child);
 //
 //        // If any child has a rotation different from the desired rotation, return false
 //        if (!childRotationCheck)
 //        {
 //            return false;
 //        }
 //    }
 //
 //    return true;
 //}
}
