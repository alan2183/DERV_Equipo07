using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlTiempo : MonoBehaviour
{
    int contador_segundos;
    [SerializeField] TextMeshProUGUI Tiempo;
    [SerializeField] TextMeshProUGUI mensajito;


    // Start is called before the first frame update
    void Start()
    {
        contador_segundos = 20;
        Tiempo.text = contador_segundos.ToString();
        StartCoroutine("corrutinaTiempo");
    }
    // Update is called once per frame
    void Update()
    {   
    }
    IEnumerator corrutinaTiempo()
    {
        while (contador_segundos >= 0)
        {
            Tiempo.text = contador_segundos--.ToString();
            yield return new WaitForSeconds(0.5f);
        }
        mensajito.text = "Juego Terminado";
        
    }
}