using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerEndGame : MonoBehaviour
{
    public GameObject endScreen;
    public string scene;
    private void OnTriggerEnter(Collider other) {
        endScreen.SetActive(true);
        Invoke("GoToMainMenu",10f);
    }

    private void GoToMainMenu(){
        SceneManager.LoadScene(scene);
    }
}
