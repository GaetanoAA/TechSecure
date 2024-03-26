using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificaSequenzaCubi : MonoBehaviour
{
    public GameObject cubo_bianco;
    public GameObject cubo_rosso;
    public GameObject cubo_verde;
    public GameObject cubo_giallo;

    public GameObject ricompensaVittoria;

    private GameObject displayImage;

    private bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        flag = false;
        displayImage = GameObject.Find("displayImage");
    }

    // Update is called once per frame
    void Update()
    {
        if (cubo_bianco.GetComponent<AutenticazioneCuboBianco>().Corretto && cubo_rosso.GetComponent<AutenticazioneCuboRosso>().Corretto
            && cubo_verde.GetComponent<AutenticazioneCuboVerde>().Corretto && cubo_giallo.GetComponent<AutenticazioneCuboGiallo>().Corretto
            && !flag)
        {
            ricompensaVittoria.SetActive(true);
            flag = true;
        }
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
