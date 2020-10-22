using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    Animator animatorComponent;
    // Start is called before the first frame update
    void Start()
    {
        animatorComponent = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.A))
        {
            animatorComponent.Play("Base Layer.sombra_taunt_Dorin");
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            animatorComponent.Play("Base Layer.Photoframe");
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            animatorComponent.Play("Base Layer.ArmatureAction");
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            animatorComponent.Play("Base Layer.combo");
        }
    }
}
