using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Clock : MonoBehaviour, IInteractable
{
    public float delay = 0f;
    public void Interact(DisplayImage currentDisplay)
    {
        this.gameObject.GetComponent<Animation>().Play();
        Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
        Instantiate(Resources.Load<GameObject>("I haven't made it yet"));
    }
}
    
