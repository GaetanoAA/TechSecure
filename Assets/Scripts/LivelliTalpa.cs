using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LivelliTalpa : MonoBehaviour
{
    private GameObject talpa;
    public int Numerolivello;
    public GameObject ScreenPanel;
    private string inputRisposta;
    public GameObject hacker2;
    public GameObject hacker3;
    public GameObject hackerMorto1;
    public GameObject hackerMorto2;
    public GameObject hackerMorto3;
    public GameObject rispostaSbagliata;
    public GameObject ricompensaVittoria;

    // Start is called before the first frame update
    void Start()
    {
        Numerolivello = 1;
       talpa = GameObject.Find("Talpa");  
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.name == "Livello1")
        {
            VerificaRispostaLivello1();
        }else if (this.gameObject.name == "Livello2")
        {
            VerificaRispostaLivello2();
        }
        else if (this.gameObject.name == "Livello3"){

            VerificaRispostaLivello3();
        }
        else
        {
            Debug.Log("Completato");
        }
    }

    void VerificaRispostaLivello1()
    {
        
            if (Input.GetKey(KeyCode.Return))
            {

                inputRisposta = ScreenPanel.transform.Find("Text").GetComponent<Text>().text;

                ScreenPanel.transform.Find("Text").GetComponent<Text>().text = "";


                if (inputRisposta == "1")
                {

                    Destroy(GameObject.Find("ScreenActivetor"));
                    Destroy(ScreenPanel);
                    Destroy(GameObject.Find("Livello1"));
                    Destroy(GameObject.Find("hacker1"));
                    hacker2.SetActive(true);
                    hackerMorto1.SetActive(true);
                  
                }
                else
                {
                    rispostaSbagliata.SetActive(true);
                   
                }
            }
        
    }

    void VerificaRispostaLivello2()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            inputRisposta = ScreenPanel.transform.Find("Text").GetComponent<Text>().text;

            ScreenPanel.transform.Find("Text").GetComponent<Text>().text = "";


            if (inputRisposta == "4")
            {

                Destroy(GameObject.Find("ScreenActivetor"));
                Destroy(ScreenPanel);
                Destroy(GameObject.Find("Livello2"));
                Destroy(GameObject.Find("hacker2"));
                hacker3.SetActive(true);
                hackerMorto2.SetActive(true);
            }
            else
            {
                rispostaSbagliata.SetActive(true);

            }
        }
    }

    void VerificaRispostaLivello3()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            inputRisposta = ScreenPanel.transform.Find("Text").GetComponent<Text>().text;

            ScreenPanel.transform.Find("Text").GetComponent<Text>().text = "";


            if (inputRisposta == "2")
            {
                Destroy(GameObject.Find("ScreenActivetor"));
                Destroy(ScreenPanel);
                Destroy(GameObject.Find("Livello3"));
                Destroy(GameObject.Find("hacker3"));
                hackerMorto3.SetActive(true);
                ricompensaVittoria.SetActive(true);
                // GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/chess_solved"); //sprite cubi

            }
            else
            {
                rispostaSbagliata.SetActive(true);
            }
        }
    }

}
