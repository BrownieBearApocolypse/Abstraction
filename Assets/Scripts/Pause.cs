using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject pausemenu;
   

    public void PauseS()
    {
        this.gameObject.GetComponent<AudioSource>().Play();
        pausemenu.SetActive(true);
    }

    public void Exit()
    {
        pausemenu.SetActive(false);  
    }

    public void CloseGame()
    {
        Application.Quit();
    }
        
        
}
