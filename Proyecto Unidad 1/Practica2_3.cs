using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Practica2_3 : MonoBehaviour
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
     void mostrarDialogo(){
        txt_mensaje.text = charla[contador].texto;
        txt_nombre.text=charla[contador].name;
        foto_personaje.sprite=charla[contador].image;
        fondo.sprite=charla[contador].fondo_conversacion;
     }
    // Start is called before the first frame update
    void Start()
    {
        contador=0;
        mostrarDialogo();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            contador++;

            contador = contador%charla.Count;
            Debug.Log(contador);
            mostrarDialogo();
        }
    }
}
