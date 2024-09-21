using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovRtoCompuesto : MonoBehaviour
{
    [SerializeField]float speed = 10f;
     [SerializeField]float velocidad_movimiento = 5;
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        float angulo = 5f * speed* Time.deltaTime;

        if(Input.GetKey(KeyCode.Q)){
            transform.Rotate(0,angulo *-1, 0);
        }else if(Input.GetKey(KeyCode.E)){
            transform.Rotate(0,angulo,0);
        }

        //Arriba - Abajo
        if(Input.GetKey(KeyCode.W)){
        //transform.Translate(transform.forward * velocidad *Time.deltaTime);
        transform.position += transform.forward*velocidad_movimiento*Time.deltaTime;

        }else if(Input.GetKey(KeyCode.S)){
            //transform.Translate(transform.forward * velocidad *-1 *Time.deltaTime);
            transform.position += transform.forward*-1*velocidad_movimiento*Time.deltaTime;
        }
        //Izquierda - Derecha
        if(Input.GetKey(KeyCode.A)){
        //transform.Translate(transform.forward * velocidad *Time.deltaTime);
        transform.position += transform.right *-1 *velocidad_movimiento*Time.deltaTime;

        }else if(Input.GetKey(KeyCode.D)){
            //transform.Translate(transform.forward * velocidad *-1 *Time.deltaTime);
            transform.position += transform.right*velocidad_movimiento*Time.deltaTime;
    }
}
}
