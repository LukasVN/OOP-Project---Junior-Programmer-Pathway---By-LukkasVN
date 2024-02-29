using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    protected bool onInteractRange = false;

    protected virtual void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            Interact();
        }
    }

    protected virtual void Interact(){
        Debug.Log("Interaction");
    }

    protected virtual void OnTriggerEnter(Collider other) {
        onInteractRange = true;
    }
    protected virtual void OnTriggerExit(Collider other) {
        onInteractRange = false;
    }
    
}
