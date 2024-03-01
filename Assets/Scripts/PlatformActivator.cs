using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformActivator : Interactable
{
    public GameObject[] platforms;
    public override void Interact()
    {
        foreach (GameObject platform in platforms)
        {
            platform.SetActive(true);
        }
        Destroy(gameObject);
    }
}
