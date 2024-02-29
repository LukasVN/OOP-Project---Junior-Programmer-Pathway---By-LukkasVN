using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnPressedLoadScene : MonoBehaviour
{
    public string sceneToLoad;

    public void LoadScene(){
        Invoke("InvokeLoadScene",0.25f);
    }

    public void InvokeLoadScene(){
        SceneManager.LoadScene(sceneToLoad);
    }
}
