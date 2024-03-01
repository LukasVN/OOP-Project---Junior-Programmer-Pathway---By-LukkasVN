using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    protected bool onInteractRange = false;

    protected virtual void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && onInteractRange){
            Interact();
        }
    }

    public virtual void Interact(){
        Debug.Log("Interaction");
    }

    protected virtual void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            onInteractRange = true;
        }
    }
    protected virtual void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player")){
            onInteractRange = false;
        }
    }
    
}
