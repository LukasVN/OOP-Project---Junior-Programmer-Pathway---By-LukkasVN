using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class OnInteractDissapear : Interactable
{
    public override void Interact()
    {
        Destroy(gameObject);
    }
}
