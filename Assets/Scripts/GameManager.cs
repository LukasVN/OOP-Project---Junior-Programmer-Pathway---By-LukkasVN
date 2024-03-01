using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI coinsText;
    //ENCAPSULATION
    public int coinCounter {get; set;}
    public int targetFPS = 144;

    private void Awake() {
        instance = this;
    }

    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = targetFPS;
    }

    public void addCoin(){
        coinCounter++;
        coinsText.text = "Coins: "+coinCounter+" / 10";
    }
}
