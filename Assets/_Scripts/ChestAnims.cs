using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animation))] //Verificar que es lo que hace

public class ChestAnims : MonoBehaviour
{
    [SerializeField] private Animation animation;
    void Start()
    {
        animation = this.gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {   
            
            animation.Play(); //Reproduce el clip que tiene asignado
        }
        
    }
}
