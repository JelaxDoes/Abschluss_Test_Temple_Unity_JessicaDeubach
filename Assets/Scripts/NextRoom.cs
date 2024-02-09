using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextRoom : MonoBehaviour
{
    public Camera cameraToDeactivate;
    public Camera cameraToActivate;
    public GameObject NextRoomButton;


    public void SwitchCameras()
    {
        
        if (cameraToDeactivate != null && cameraToActivate != null)
        {
            cameraToDeactivate.gameObject.SetActive(false);
            cameraToActivate.gameObject.SetActive(true);
            NextRoomButton.SetActive(false);
        }
        else
        {
            Debug.LogWarning("Eine oder beide Kameras wurden nicht zugewiesen.");
        }
    }
}
