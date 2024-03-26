using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Linq;
using System.Text.RegularExpressions;

public class Computer : MonoBehaviour 
{
    public GameObject ScreenPanel;

    private GameObject displayImage;

    public string CorrectPassword;

    private string inputPassword;

    public GameObject ricompensaVittoria;

    void Start()
    {
        displayImage = GameObject.Find("displayImage");
    }

    void Update()
    {
        if (this.gameObject.name == "Computer")
        {
            VerifyPassword();
        }
        HideDisplay();
    }

    bool VerifyPassword()
    {
        int minLength = 8;


        if (Input.GetKey(KeyCode.Return))
        {
            inputPassword = ScreenPanel.transform.Find("Text").GetComponent<Text>().text;

            ScreenPanel.transform.Find("Text").GetComponent<Text>().text = "";


            if (inputPassword.Length < minLength)
            {
                return false;

            }

            if (!inputPassword.Any(char.IsLower))
            {
                return false;
            }

            if (!inputPassword.Any(char.IsUpper))
            {
                return false;
            }

            if (!inputPassword.Any(char.IsDigit))
            {
                return false;
            }

            if(!Regex.IsMatch(inputPassword, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]"))
            {
                return false;
            }
            Destroy(GameObject.Find("ScreenActivetor"));
            Destroy(ScreenPanel);
            ricompensaVittoria.SetActive(true);
            this.gameObject.name = "Monitor";

        }
        return false;
    }

    void HideDisplay()
    {
        if(Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {
            this.gameObject.SetActive(false);
        }

        if(displayImage.GetComponent<DisplayImage>().CurrentState == DisplayImage.State.normal)
        {
            this.gameObject.SetActive(false);
        }
    }
}
