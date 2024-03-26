using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LivelliDDos : MonoBehaviour
{

    private GameObject ddos;
    public int Numerolivello;
    public GameObject ScreenPanel;
    private string inputRisposta;
    public GameObject attaccante2;
    public GameObject attaccante3;
    public GameObject attaccante4;
    public GameObject attaccanteMorto1;
    public GameObject attaccanteMorto2;
    public GameObject attaccanteMorto3;
    public GameObject attaccanteMorto4;
    public GameObject rispostaSbagliata;
    public GameObject ricompensaVittoria;

    // Start is called before the first frame update
    void Start()
    {
        Numerolivello = 1;
        ddos = GameObject.Find("DDos");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.name == "Livello1")
        {
            VerificaRispostaLivello1();
        }
        else if (this.gameObject.name == "Livello2")
        {
            VerificaRispostaLivello2();
        }
        else if (this.gameObject.name == "Livello3")
        {

            VerificaRispostaLivello3();
        }
        else if (this.gameObject.name == "Livello4")
        {

            VerificaRispostaLivello4();
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


            if (inputRisposta.ToLower() == "vero")
            {

                Destroy(GameObject.Find("ScreenActivetor"));
                Destroy(ScreenPanel);
                Destroy(GameObject.Find("Livello1"));
                Destroy(GameObject.Find("attaccante1"));
                attaccante2.SetActive(true);
                attaccanteMorto1.SetActive(true);

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


            if (inputRisposta.ToLower() == "falso")
            {

                Destroy(GameObject.Find("ScreenActivetor"));
                Destroy(ScreenPanel);
                Destroy(GameObject.Find("Livello2"));
                Destroy(GameObject.Find("attaccante2"));
                attaccante3.SetActive(true);
                attaccanteMorto2.SetActive(true);

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


            if (inputRisposta.ToLower() == "falso")
            {

                Destroy(GameObject.Find("ScreenActivetor"));
                Destroy(ScreenPanel);
                Destroy(GameObject.Find("Livello3"));
                Destroy(GameObject.Find("attaccante3"));
                attaccante4.SetActive(true);
                attaccanteMorto3.SetActive(true);

            }
            else
            {
                rispostaSbagliata.SetActive(true);

            }
        }

    }
    void VerificaRispostaLivello4()
    {

        if (Input.GetKey(KeyCode.Return))
        {

            inputRisposta = ScreenPanel.transform.Find("Text").GetComponent<Text>().text;

            ScreenPanel.transform.Find("Text").GetComponent<Text>().text = "";


            if (inputRisposta.ToLower() == "falso")
            {

                Destroy(GameObject.Find("ScreenActivetor"));
                Destroy(ScreenPanel);
                Destroy(GameObject.Find("Livello4"));
                Destroy(GameObject.Find("attaccante4"));
                attaccanteMorto4.SetActive(true);
                ricompensaVittoria.SetActive(true);
            }
            else
            {
                rispostaSbagliata.SetActive(true);

            }
        }

    }


}
