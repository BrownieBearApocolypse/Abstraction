using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomInObject : MonoBehaviour, IInteractable
{
    //goes on zoom object
    public float ZoomRatio = 0.5f;
    public GameObject[] changeview;
    //set object this is attached to to Ignore Raycast
    public void Interact(DisplayImage currentDisplay)
    {
        Debug.Log("ClickZoom");
        Camera.main.orthographicSize *= ZoomRatio;
        Camera.main.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        gameObject.layer = 2;
        currentDisplay.CurrentState = DisplayImage.State.zoom;
        ConstraintCamera();
        foreach (var change in changeview)
        {
            GetComponent<ChangeView>().enabled = false;
        }
    }

    void ConstraintCamera()
    {
        var height = Camera.main.orthographicSize;
        var width = height * Camera.main.aspect;

        var cameraBounds = GameObject.Find("cameraBounds");

        if (Camera.main.transform.position.x + width > cameraBounds.transform.position.x + cameraBounds.GetComponent<BoxCollider2D>().size.x / 2)
        {
            Camera.main.transform.position += new Vector3(cameraBounds.transform.position.x + cameraBounds.GetComponent<BoxCollider2D>().size.x / 2 - (Camera.main.transform.position.x + width), 0, 0);
        }

        if (Camera.main.transform.position.x - width > cameraBounds.transform.position.x - cameraBounds.GetComponent<BoxCollider2D>().size.x / 2)
        {
            Camera.main.transform.position += new Vector3(cameraBounds.transform.position.x - cameraBounds.GetComponent<BoxCollider2D>().size.x / 2 + (Camera.main.transform.position.x - width), 0, 0);
        }

        if (Camera.main.transform.position.x + height> cameraBounds.transform.position.x + cameraBounds.GetComponent<BoxCollider2D>().size.x / 2)
        {
            Camera.main.transform.position += new Vector3(cameraBounds.transform.position.x + cameraBounds.GetComponent<BoxCollider2D>().size.x / 2 - (Camera.main.transform.position.x + height), 0, 0);
        }

        if (Camera.main.transform.position.x - height > cameraBounds.transform.position.x - cameraBounds.GetComponent<BoxCollider2D>().size.x / 2)
        {
            Camera.main.transform.position += new Vector3(cameraBounds.transform.position.x - cameraBounds.GetComponent<BoxCollider2D>().size.x / 2 + (Camera.main.transform.position.x + height), 0, 0);
        }
    }
}
