using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public void Update()
    {
        
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void PauseS()
    {
        GameObject.Find("PauseMenu").SetActive(true);
    }

    public void Exit()
    {
        GameObject.Find("PauseMenu").SetActive(false);  
    }
}
