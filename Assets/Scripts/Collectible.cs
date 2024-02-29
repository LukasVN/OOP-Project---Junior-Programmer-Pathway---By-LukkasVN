using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    protected virtual void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            Collect();
            Destroy(gameObject);
        }
    }

    protected virtual void Collect(){
        Debug.Log("Collected!");
    }
}
