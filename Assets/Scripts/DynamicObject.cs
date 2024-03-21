using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicObject : MonoBehaviour, IInteractable
{
    public string UnlockItem;

    public GameObject ChangedStateSprite;

    private GameObject inventory;


    void Start()
    {
        ChangedStateSprite.SetActive(false);
        inventory = GameObject.Find("Inventory");
    }

    public void Interact(DisplayImage currentDisplay)
    {
        if (inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem || UnlockItem == "")
        {
            ChangedStateSprite.SetActive(true);
            inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ClearSlot();
        }

    }
}