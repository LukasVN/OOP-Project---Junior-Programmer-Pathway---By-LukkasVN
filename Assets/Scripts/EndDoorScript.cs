using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDoorScript : MonoBehaviour
{
    void Update()
    {
        if(GameManager.instance.coinCounter == 10){
            Destroy(gameObject);
        }
    }
}
