using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Instrucciones : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI indicacion;
    [SerializeField] TextMeshProUGUI perdida;
    
    public string[] nombres = { "Rojo", "Verde", "Azul" }; 
    private string colorElegido;

    void Start()
    {
        
        Seleccionado(); 
        perdida.gameObject.SetActive(false);
    }

    public void Seleccionado(){
        int index = Random.Range(0, nombres.Length);
        colorElegido = nombres[index]; 

      
        Debug.Log("Color seleccionado: " + colorElegido);
        
       
        indicacion.text = "Toma el cubo: " +colorElegido; 
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("TakenObject"))
        {
           
            colorCubo CuboC = other.gameObject.GetComponent<colorCubo>();

            if (CuboC != null && CuboC.color == colorElegido)
            {
                Debug.Log("GANASTEEEEEE!");
                StartCoroutine(TiempoEspera()); 

            }
            else
            {
                Debug.Log("PERDISTEEEEEEEE");
                perdida.text ="HAS PERDIDO!";
                perdida.gameObject.SetActive(true);
            }
        } 
    }
     IEnumerator TiempoEspera()
    {
        yield return new WaitForSeconds(1f);  
        Seleccionado(); 
    }
}
