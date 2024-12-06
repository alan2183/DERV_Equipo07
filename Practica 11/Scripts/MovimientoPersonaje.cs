using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    [SerializeField] float velocidad_movimiento = 2f;

    // Update is called once per frame
    void Update()
    {
        // Movimiento hacia adelante
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * velocidad_movimiento * Time.deltaTime;
        }
        // Movimiento hacia atrás
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -1 * velocidad_movimiento * Time.deltaTime;
        }

        // Movimiento hacia la izquierda
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * -1 * velocidad_movimiento * Time.deltaTime;
        }
        // Movimiento hacia la derecha
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * velocidad_movimiento * Time.deltaTime;
        }
    }
}
