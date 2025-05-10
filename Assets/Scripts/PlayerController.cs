using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 offset;
    private bool isDragging = false;

    void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isDragging = true;
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            transform.position = new Vector3(mousePosition.x + offset.x, mousePosition.y + offset.y, transform.position.z);
        }
    }
}
