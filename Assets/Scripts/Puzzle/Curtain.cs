using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Curtain : MonoBehaviour, IInteractable
{
    public string ScissorItem;
    private GameObject inventory;
    public float delay = 0f;
    public void Interact(DisplayImage currentDisplay)
    {
        if (inventory.GetComponent<InventoryManager>().currentSelectedSlot.transform.GetChild(0).GetComponent<Image>().sprite.name == ScissorItem)
        {
            this.gameObject.GetComponent<Animation>().Play();
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
        }
    }
}
