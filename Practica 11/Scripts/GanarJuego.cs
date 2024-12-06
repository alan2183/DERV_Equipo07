using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GanarJuego : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI mensajeVictoria;

    private void Start()
    {
        mensajeVictoria.gameObject.SetActive(false); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            MostrarMensajeVictoria();
        }
    }

    void MostrarMensajeVictoria()
    {
        mensajeVictoria.text = "GANASTEEE!"; 
        mensajeVictoria.gameObject.SetActive(true); 
        Time.timeScale = 0;

    }
}
