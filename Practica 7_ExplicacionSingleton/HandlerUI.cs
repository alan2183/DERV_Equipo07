using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandlerUI : MonoBehaviour
{
    public static HandlerUI Instance {get;private set;}
    TextMeshProUGUI [] contador;

    float cont_segundos;
    float tiempo_transcurrido;    

    private void Awake() {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);//elimina toda la clase
        
        }
        else{
            contador = GetComponentsInChildren<TextMeshProUGUI>();
            Instance = this;
            DontDestroyOnLoad(gameObject); 
            
        }
    }

    void Start()
    {
        cont_segundos = 0;
        tiempo_transcurrido = 0;
    }
    void Update()
    {
        tiempo_transcurrido += Time.deltaTime;
        if(tiempo_transcurrido > 1.0f)
        {
            cont_segundos++;
            tiempo_transcurrido=0;
            contador[0].text = cont_segundos.ToString();
        }
    }
}
