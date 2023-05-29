using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Clock : MonoBehaviour, IInteractable
{
    public float delay = 0.1f;
    private PuzzleManager manager;

    public void Start()
    {
        manager = GameObject.Find("script holder").GetComponent<PuzzleManager>();        
    }

    public void Interact(DisplayImage currentDisplay)
    {
        if (currentDisplay.CurrentState == DisplayImage.State.zoom)
        {
            this.gameObject.GetComponent<Animator>().SetTrigger("Clicked");
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
            Instantiate(Resources.Load<GameObject>("I haven't made it yet"));
            manager.ClockIsCompleted = true;
        }
    }
}
    
