using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour, IInteractable
{
    private PuzzleManager manager;
    public bool isRotated;
    public float rotationTolerance = 1f; // Tolerance for rotation comparison

    public void Start()
    {
        manager = GameObject.Find("script holder").GetComponent<PuzzleManager>();
    }

    public void Interact(DisplayImage currentDisplay)
    {
        if (currentDisplay.CurrentState == DisplayImage.State.doubleZoom)
        {
            gameObject.transform.Rotate(0f, 0f, 90f);
        }

        Quaternion desiredRotation = Quaternion.Euler(0f, 0f, 0f);
        Quaternion currentRotation = gameObject.transform.rotation;

        float angleDifference = Quaternion.Angle(currentRotation, desiredRotation);
        float positiveAngleDifference = angleDifference >= 180f ? 360f - angleDifference : angleDifference;
        Debug.Log(gameObject.transform.rotation);
        Debug.Log(Mathf.Approximately(angleDifference, 0f) || Mathf.Approximately(angleDifference, 360f) || Mathf.Approximately(angleDifference, 180f));
        if (positiveAngleDifference <= rotationTolerance)
        {
            isRotated = true;
        }
    }
}
