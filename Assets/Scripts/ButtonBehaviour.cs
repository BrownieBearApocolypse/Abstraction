using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    public void ShutDown()
    {
        GetComponent<ButtonBehaviour>().enabled = false;
    }
}
