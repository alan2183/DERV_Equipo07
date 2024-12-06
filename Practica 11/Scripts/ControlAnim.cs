using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnim : MonoBehaviour
{
    [SerializeField] Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim.Play("Idle");
    }
    int index = 0;
    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space)){
            switch (index){
                case 0: anim.Play("Macarena Dance");
                break;
                case 1: anim.Play("Hip Hop Dance");
                break;
                case 2: anim.Play("Swing Dancing");
                break;
        }
        index++;
        index = index%3;
    }
}
}
