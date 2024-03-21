using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Computer : MonoBehaviour
{
    public GameObject ScreenPanel;

    private bool isCorrectPassword = false;

    public string CorrectPassword;

    private string inputPassword;

    void Start()
    {
        ScreenPanel.SetActive(false);
        this.gameObject.SetActive(false);
    }

    void Update()
    {
        VerifyPassword();
    }

    public void VerifyPassword()
    {
        if (isCorrectPassword) return;

        if (Input.GetKey(KeyCode.Return))
        {
            
            inputPassword = ScreenPanel.transform.Find("Text").GetComponent<Text>().text;

            ScreenPanel.transform.Find("Text").GetComponent<Text>().text = "";


            if (inputPassword == CorrectPassword)
            {
                isCorrectPassword = true;
                Destroy(GameObject.Find("ScreenActivator"));
                Destroy(ScreenPanel);
               // GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/chess_solved"); //sprite cubi
            }
        }
    }
}
