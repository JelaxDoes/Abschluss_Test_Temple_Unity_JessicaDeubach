using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinButton : MonoBehaviour
{
    public GameObject WinScreen;

    public void ActivateWinScreen()
    {
        WinScreen.SetActive(true);
    }
}
