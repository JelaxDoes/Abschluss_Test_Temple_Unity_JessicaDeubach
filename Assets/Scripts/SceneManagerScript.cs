using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public GameObject StartScreen;
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject DoneScreen;
    public GameObject WinButton;
    public GameObject NextButton;
    public void ReloadScene()
    {
        Camera1.SetActive(true);
        Camera3.SetActive(false);
        DoneScreen.SetActive(false);
        WinButton.SetActive(false);
        NextButton.SetActive(true);
    }

    public void LoadScene()
    {
        Camera[] allCameras = FindObjectsOfType<Camera>();
        foreach (Camera cam in allCameras)
        {
            if (cam != Camera1)
            {
                cam.gameObject.SetActive(false);
            }
        }

        // Aktiviere Kamera 1
        Camera1.gameObject.SetActive(true);
        StartScreen.SetActive(false);
    }
}

