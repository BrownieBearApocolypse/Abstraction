using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayImage : MonoBehaviour
{
    public GameObject[] Wall;


    public int CurrentWall
    {
        get { return currentWall; }
        set
        {
            if (value == 5)
                currentWall = 1;
            else if (value == 0)
                currentWall = 4;
            else
                currentWall = value;
        }
    }

    private int currentWall;
    private int previousWall;

    void Start()
    {
        Wall = GameObject.FindGameObjectsWIthTag("Screen");
        previousWall = 0;
        currentWall = 1;
    }

    void Update()
    {
        for (int i = 0; i < wall.Length; i++)
        {
            if (currentWall != previousWall)
            {
                wall[i].SetActive(false);
            }            
        } 
        previousWall = currentWall;

    }           
    
}
