using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class CoinScript : Collectible
{
    public override void Collect(){
        GameManager.instance.addCoin();
    }
}
