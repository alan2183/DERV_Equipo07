using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ManagerLife : MonoBehaviour
{
    Image valorVida;

    [SerializeField] float vida; 
    [SerializeField] float damagePorGolpe; 
    [SerializeField] TextMeshProUGUI mensajeDerrota; 
    private void Start()
    {
        vida = 1; 
        valorVida = GameObject.Find("Vida").GetComponent<Image>(); 
        valorVida.fillAmount = vida; 
        mensajeDerrota.gameObject.SetActive(false); 
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Jugador"))
        {
            ReducirVida();
        }
    }

    void ReducirVida()
    {
        vida -= damagePorGolpe; 
        vida = Mathf.Clamp(vida, 0, 1); 
        valorVida.fillAmount = vida; 

        if (vida <= 0)
        {
            MostrarMensajeDerrota();
        }
    }

    void MostrarMensajeDerrota()
    {
        mensajeDerrota.text = "PERDISTE"; 
        mensajeDerrota.gameObject.SetActive(true); 
        Time.timeScale = 0;
        }
    
}