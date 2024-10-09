using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ManagerConversacion2 : MonoBehaviour
{
    [System.Serializable]
    public struct Dialogo{
        public string name;
        public string texto;
        public Sprite Imagen;
    }
    public List<Dialogo> charla;
    [SerializeField] TextMeshProUGUI txt_mensajes;
    [SerializeField] TextMeshProUGUI txt_nombre;
    [SerializeField] Image foto_personaje;
    int contador;

    void mostrarDialogo(){
        txt_mensajes.text = charla[contador].texto; //actualiza el text
        txt_nombre.text = charla[contador].name; // actualiza el nombre
        foto_personaje.sprite = charla[contador].Imagen;
    }
    // Start is called before the first frame update
    void Start()
    {
        contador = 0;    //inicializa el contador
        mostrarDialogo(); //muestra el primer dialogo
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)){
            contador++;
            contador%=charla.Count; // verifica que el contador se mantenga dentro del rangode la lista
            Debug.Log(contador);
            mostrarDialogo(); // muestra el sig dialogo
        }
    }
}
