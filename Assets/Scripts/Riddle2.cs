using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riddle2 : MonoBehaviour
{
    public Material defaultMaterial;
    public Material originalMaterial;
    private Renderer objectRenderer;
    private bool isdefaultMaterial = false;

    private void Start()
    {
        objectRenderer = GetComponent<MeshRenderer>();
    }

    void OnMouseDown()
    {
        if (isdefaultMaterial)
        {
            objectRenderer.material = originalMaterial;
            isdefaultMaterial = false;
            Debug.Log("Licht an");
        }
        else
        {
            objectRenderer.material = defaultMaterial;
            isdefaultMaterial = true;
            Debug.Log("Licht aus");
        }
    }


}
