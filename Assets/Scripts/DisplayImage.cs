using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayImage : MonoBehaviour
{
    public enum State
    {
        normal, zoom, ChangedView, doubleZoom
    };

    public State CurrentState { get; set; }

    public int CurrentWall
    {
        get
        {    
            return currentWall; 
        }
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
    
}

