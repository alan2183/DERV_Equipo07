using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Asegúrate de incluir esto

public class Inicio : MonoBehaviour
{

    private void Update()
    {
        int escena_actual = SceneManager.GetActiveScene().buildIndex;

        if(Input.GetKeyDown(KeyCode.C))
        {

            if(escena_actual == 0)
        {
            cambiodeEscena(1);
        }
     
}
    }
     public void cambiodeEscena(int index_escena_ir)
    {
        SceneManager.LoadScene(index_escena_ir);
    }
}
    