using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AutenticazioneCuboVerde : MonoBehaviour, IInteractable
{
    public GameObject ChangedStateSprite;

    public string UnlockItem;


    public bool Corretto = false;

    //public GameObject EscapeMessage;

    private GameObject inventory;


    void Start()
    {
        Corretto = false;
        ChangedStateSprite.SetActive(false);
        inventory = GameObject.Find("Inventory");
    }



    public void Interact(DisplayImage currentDisplay)
    {
        if (inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem || UnlockItem == "")
        {
            ChangedStateSprite.SetActive(true);
            this.gameObject.SetActive(false);
            Corretto = true;
            //Instantiate(EscapeMessage, GameObject.Find("wall7").transform);
        }

    }
}
