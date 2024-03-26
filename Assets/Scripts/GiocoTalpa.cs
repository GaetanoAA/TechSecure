using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class GiocoTalpa : MonoBehaviour
{
    public bool IsCompleted { get; private set; }
    private bool itemSpawn;

    public GameObject ClaimItem;

    private GameObject displayImage;

    private bool isCorrectPassword = false;
    private string CorrectPassword;

    private string inputPassword;

    void Start()
    {
        itemSpawn = false;
        displayImage = GameObject.Find("displayImage");
    }

    void Update()
    {
        VerifyPassword();
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

    bool CompletePuzzle()
    {
        if (IsCompleted) return false;

        

        return IsCompleted;
    }

    public void VerifyPassword()
    {
        
    }
}
