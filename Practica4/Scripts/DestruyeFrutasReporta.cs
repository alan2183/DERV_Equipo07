using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestruyeFrutasReporta : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI texto_contadorCreepers;
    [SerializeField] TextMeshProUGUI texto_contadorEndermans;
    public int contadorCreepers;
    public int contadorEndermans;

    
    // Start is called before the first frame update
    void Start()
    {
        contadorCreepers = 0;
        contadorEndermans = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter(
        Collision other){

    GameObject obj = other.gameObject;
    if(obj.CompareTag("Creeper")){
        Destroy(obj);
        contadorCreepers++;
        texto_contadorCreepers.text = contadorCreepers.ToString();
    }
    else if(obj.CompareTag("Enderman")){
        Destroy(obj);
        contadorEndermans++;
        texto_contadorEndermans.text = contadorEndermans.ToString();
    }
    }
}

