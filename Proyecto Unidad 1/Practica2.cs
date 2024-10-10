using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Practica2 : MonoBehaviour
{
    [System.Serializable]
    public struct Dialog
    {
        public string name;
        public string texto;
        public Sprite image;
        public Sprite fondo_conversacion;
    }

    public List<Dialog> charla;
    [SerializeField] TextMeshProUGUI txt_mensaje;
    [SerializeField] TextMeshProUGUI txt_nombre;
    [SerializeField] Image foto_personaje;
    [SerializeField] Image fondo;

    int contador;

    void mostrarDialogo()
    {
        txt_mensaje.text = charla[contador].texto;
        txt_nombre.text = charla[contador].name;
        foto_personaje.sprite = charla[contador].image;
        fondo.sprite = charla[contador].fondo_conversacion;
    }

    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
        mostrarDialogo();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            contador++;

            if (contador >= charla.Count)
            {
                Debug.Log("Diálogos finalizados, cambiando escena...");
                cambiarEscena(); // Llamar al cambio de escena cuando los diálogos terminan
            }
            else
            {
                mostrarDialogo();
            }
        }
    }

    // Cambia de escena cuando los diálogos terminan
    public void cambiarEscena()
    {
        int escena_actual = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("Escena actual: " + escena_actual);

        // Cambia a la siguiente escena
        if (escena_actual == 0)
        {
            Debug.Log("Cambiando a la escena 1...");
            SceneManager.LoadScene(1); // Ir a la escena 2
        }
        else if (escena_actual == 1)
        {
            Debug.Log("Cambiando a la escena 2...");
            SceneManager.LoadScene(2); // Ir a la escena 3
        }
        else if (escena_actual == 2)
        {
            Debug.Log("Cambiando a la escena 3...");
            SceneManager.LoadScene(3); // Ir a la escena 4
        }
        else if (escena_actual == 3)
        {
            Debug.Log("Cambiando a la escena 4...");
            SceneManager.LoadScene(4); // Ir a la escena 5
        }
    }
}
