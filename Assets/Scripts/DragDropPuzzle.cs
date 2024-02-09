using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDropPuzzle : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 startPosition;
    private float distance = 10f;

    public Transform[] snapTargets;
    public float snapDistance = 3f; 

    void OnMouseDown()
    {
        isDragging = true;
        startPosition = transform.position;
        Debug.Log("angeklickt");
    }

    void OnMouseUp()
    {
        isDragging = false;
        SnapToTargets(); 
        Debug.Log("losgelassen");
    }

    void Update()
    {
        if (isDragging)
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }

        
        if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(0, 45, 0); 
        }
    }


    void SnapToTargets()
    {
        float minDistance = Mathf.Infinity;
        Transform closestTarget = null;

        // Durchlaufe alle Snap-Ziele und finde das nächstgelegene
        foreach (Transform target in snapTargets)
        {
            float currentDistance = Vector3.Distance(transform.position, target.position);
            if (currentDistance < snapDistance && currentDistance < minDistance)
            {
                minDistance = currentDistance;
                closestTarget = target;
                Debug.Log("snap");
            }
        }

        // Wenn ein Snap-Ziel gefunden wurde, snappe zum nächsten Ziel
        if (closestTarget != null)
        {
            transform.position = closestTarget.position;
            // Zusätzliche Logik zur Rotation anpassen, falls erforderlich
        }
        else
        {
            transform.position = startPosition; // Setze das Objekt zur Startposition zurück
            Debug.Log("nicht gesnappt");
        }
    }
}

