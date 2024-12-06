using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClaseSingleton : MonoBehaviour
{
    public static ClaseSingleton Instance{get;private set;}

    private void Awake() {
       
       if(Instance != null && Instance != this)
       {
        //Destroy(this);
        Destroy(gameObject);//elimina toda la clase

       }
       else{
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
        
       }
        
    /*void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            int index_escena = SceneManager.GetActiveScene().buildIndex;
            index_escena++;
            index_escena %=3;
            cambioEscena(index_escena);
        }
        
    }*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            int index_escena = SceneManager.GetActiveScene().buildIndex;
            index_escena++;
            index_escena %= 3; // Cambia de escena en ciclo entre 3 escenas
            cambioEscena(index_escena);
        }
    }


    public void cambioEscena(int idx)
    {
        SceneManager.LoadScene(idx);
    }
}
