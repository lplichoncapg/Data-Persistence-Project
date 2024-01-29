using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void StartMainScene(){
        SceneManager.LoadScene(1);
    }

    public void QuitApplication(){
        #if UNITY_EDITOR
        if(EditorApplication.isPlaying)
        {
            EditorApplication.isPlaying = false;
        }
        #endif

        Application.Quit();
    }
}
