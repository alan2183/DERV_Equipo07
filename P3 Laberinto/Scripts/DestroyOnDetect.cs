using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DestroyOnDetect : MonoBehaviour
{
     [SerializeField] TextMeshProUGUI texto_cont;
    int contador;

    private void OnCollisionEnter(Collision other) {
        GameObject obj = other.gameObject;
        if (obj.CompareTag("TagEnemy")){
            Destroy(obj);
            contador ++;
            texto_cont.text=contador.ToString();
        } 
        
    }
    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
