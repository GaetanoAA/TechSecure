using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giocoDDos : MonoBehaviour
{
    private GameObject displayImage;

    void Start()
    {
        displayImage = GameObject.Find("displayImage");
    }

    void Update()
    {
        HideDisplay();
    }

    void HideDisplay()
    {
        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {
            this.gameObject.SetActive(false);
        }

        if (displayImage.GetComponent<DisplayImage>().CurrentState == DisplayImage.State.normal)
        {
            this.gameObject.SetActive(false);
        }
    }
}
