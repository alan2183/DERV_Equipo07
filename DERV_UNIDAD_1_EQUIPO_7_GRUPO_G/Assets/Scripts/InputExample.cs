using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputExample : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            Debug.Log("A");

        }  

        if(Input.GetKey(KeyCode.B)){
            Debug.Log("B");
        }  

        if(Input.GetKey(KeyCode.C)){
            Debug.Log("C");
        } 

        if(Input.GetKey(KeyCode.D)){
            Debug.Log("D");
        }  
    }
}
