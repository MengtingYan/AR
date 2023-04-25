using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class Exit : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
    }
    public void OnCloseGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }



}
