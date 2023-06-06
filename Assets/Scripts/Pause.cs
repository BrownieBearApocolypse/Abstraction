using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject pausemenu;
    public void Update()
    {
        
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void PauseS()
    {
        pausemenu.SetActive(true);
    }

    public void Exit()
    {
        pausemenu.SetActive(false);  
    }
}
