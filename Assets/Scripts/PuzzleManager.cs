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

    public bool allAre0Degrees = false;
    private GameObject rotated;

    public void Start()
    {
        rotated = GameObject.Find("RotateThisShit");
    }

    public void IsRotateCompleted()
    {        
        bool allChildrenZeroRotation = CheckChildrenRotation(rotated.transform);
        if (allChildrenZeroRotation)
        {
            allAre0Degrees = true;
            rotated.transform.GetChild(0).GetComponent<Rotate>().enabled = false;
        }
    }


    private bool CheckChildrenRotation(Transform parent)
    {
        foreach (Transform child in parent)
        {
            // Check if the child's rotation is not equal to zero
            float childRotation = child.rotation.eulerAngles.y;
            if (childRotation != 0f && childRotation != 360f)
            {
                return false;
            }

            // Recursive call to check the rotation of the child's children
            bool childRotationCheck = CheckChildrenRotation(child);

            // If any child has a non-zero rotation, return false
            if (!childRotationCheck)
            {
                return false;
            }
        }

        return true;
    }
}
