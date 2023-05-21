using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour
{
    public ItemGrab itemGrab;

    public void OnMouseDown()
    {
        ItemGrab.PickUpItem();
    }
}
