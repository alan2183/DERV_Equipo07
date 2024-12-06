using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using TMPro;

public class HandlerUI : MonoBehaviour
{
    [SerializeField]

    GameObject objetoPanel;
    int contador;
    float cont_tiempo ;
    //[SerializeField] TextMeshProUGUI text_contador;
    // Start is called before the first frame update
   void Start()
    {
        /*contador = 0;
        cont_tiempo = 0;
        text_contador.text = contador.ToString();*/ 
        objetoPanel.SetActive(false);
    }
    
    
    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex==0 && objetoPanel.activeSelf){
            Debug.Log("Update activo: en escena 0 y el panel está visible");
            /*cont_tiempo += Time.deltaTime;
            if (cont_tiempo >= 1f){
                contador++;
                text_contador.text = contador.ToString();
                cont_tiempo = 0;
            }*/
        }
    }
    
    public void activaPanel(bool isVisible){
       /* contador = 0;
        text_contador.text = contador.ToString();*/
        objetoPanel.SetActive(isVisible);
    }
}
