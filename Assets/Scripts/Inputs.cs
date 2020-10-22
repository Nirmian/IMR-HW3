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
            animatorComponent.SetBool("Anim1", true);

            animatorComponent.SetBool("Anim2", false);
            animatorComponent.SetBool("Anim3", false);
            animatorComponent.SetBool("Anim4", false);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            animatorComponent.SetBool("Anim2", true);

            animatorComponent.SetBool("Anim1", false);
            animatorComponent.SetBool("Anim3", false);
            animatorComponent.SetBool("Anim4", false);
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            animatorComponent.SetBool("Anim3", true);

            animatorComponent.SetBool("Anim2", false);
            animatorComponent.SetBool("Anim1", false);
            animatorComponent.SetBool("Anim4", false);
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            animatorComponent.SetBool("Anim4", true);

            animatorComponent.SetBool("Anim2", false);
            animatorComponent.SetBool("Anim3", false);
            animatorComponent.SetBool("Anim1", false);
        }
    }
}
