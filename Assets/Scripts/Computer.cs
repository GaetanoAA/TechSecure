using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Linq;
using System.Text.RegularExpressions;

public class Computer : MonoBehaviour //--IPointerClickHandler
{
    public GameObject ScreenPanel;

    private bool isCorrectPassword = false;

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
            Debug.Log("ENTRATO");
            inputPassword = ScreenPanel.transform.Find("Text").GetComponent<Text>().text;

            ScreenPanel.transform.Find("Text").GetComponent<Text>().text = "";


            if (inputPassword.Length < minLength)
            {
                Debug.Log("Arrivato1");
                return false;

            }

            if (!inputPassword.Any(char.IsLower))
            {
                Debug.Log("Arrivato2");
                return false;
            }

            if (!inputPassword.Any(char.IsUpper))
            {
                Debug.Log("Arrivato3");
                return false;
            }

            if (!inputPassword.Any(char.IsDigit))
            {
                Debug.Log("Arrivato4");
                return false;
            }

            if(!Regex.IsMatch(inputPassword, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]"))
            {
                Debug.Log("Arrivato5");
                return false;
            }
            Debug.Log("Arrivato6");
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

    /*public void OnPointerClick(PointerEventData eventData)
    {
        ScreenPanel.SetActive(false);
    }*/
}
