using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hand : MonoBehaviour, IInteractable
{
    private PuzzleManager manager;
    public string Pot;
    private GameObject inventory;
    public GameObject MainCamera;
    public GameObject PauseMenu;

    public void Start()
    {
        manager = GameObject.Find("script holder").GetComponent<PuzzleManager>();
        inventory = GameObject.Find("Inventory");
    }

    public void Interact(DisplayImage currentDisplay)
    {
        Slot currentSlot = inventory.GetComponent<InventoryManager>().currentSelectedSlot.GetComponent<Slot>();

        if (currentSlot.ItemProperty == Slot.Property.usable 
            && inventory.GetComponent<InventoryManager>().currentSelectedSlot.transform.GetChild(0).GetComponent<Image>().sprite.name == Pot)
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            currentSlot.ClearSlot();
            manager.WindowIsCompleted = true;
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.34f, 0.5f, 0.8f, 1f);
            Debug.Log("done, you Did It");
            Invoke("AniamtionTime", 5);            
        }
    }

    public void AniamtionTime()
    {
        MainCamera.gameObject.GetComponent<Animator>().SetTrigger("GameOver");
        Invoke("PauseMenuYes", MainCamera.gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + MainCamera.gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime);
    }

    public void PauseMenuYes()
    {
        PauseMenu.SetActive(true);
    }
}
