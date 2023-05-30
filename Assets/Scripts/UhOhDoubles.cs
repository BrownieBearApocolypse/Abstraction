using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UhOhDoubles : MonoBehaviour
{
    public PickUp pickUp;

    public void Update()
    {
        if (pickUp.itemPickedUp == true)
        {
            gameObject.SetActive(false);
        }
    }
}
