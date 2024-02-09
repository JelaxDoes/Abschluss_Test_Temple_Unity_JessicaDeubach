using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staturen : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;
    

    private void OnMouseDown()
    {
        isDragging = true;
       
    }

    private void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 targetPos = GetMouseWorldPos() + offset;
            targetPos.y = transform.position.y;
            transform.LookAt(targetPos);
        }
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = Camera.main.transform.position.y;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}
