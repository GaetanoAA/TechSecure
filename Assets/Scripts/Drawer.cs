using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drawer : MonoBehaviour, IInteractable
{
    public string UnlockItem;

    private GameObject inventory;

    void Start()
    {
        inventory = GameObject.Find("Inventory");
    }

    public void Interact(DisplayImage currentDisplay)
    {
        if(inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem)
        {
            Debug.Log("unlock");
        } 
    }
}
