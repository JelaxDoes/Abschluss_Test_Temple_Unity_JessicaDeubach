using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    public Puzzle2 puzzleManager; 

    void OnMouseDown()
    {
       
        if (puzzleManager != null)
        {
            puzzleManager.CheckClickedLight(gameObject);
        }
    }
}
