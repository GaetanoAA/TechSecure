using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AutenticazioneCuboBianco : MonoBehaviour, IInteractable
{
    public GameObject ChangedStateSprite;

    public string UnlockItem;

    public bool Corretto=false;
    //public GameObject EscapeMessage;

    private GameObject inventory;


    void Start()
    {
        ChangedStateSprite.SetActive(false);
        inventory = GameObject.Find("Inventory");
        Corretto = false;
    }



    public void Interact(DisplayImage currentDisplay)
    {
        if (inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem || UnlockItem == "")
        {
            ChangedStateSprite.SetActive(true);
            this.gameObject.SetActive(false);
            //this.gameObject.name = "cubo1cambiato";
            Corretto = true;
            //Instantiate(EscapeMessage, GameObject.Find("wall7").transform);
        }

    }
}
