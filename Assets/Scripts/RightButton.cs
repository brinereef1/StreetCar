using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Right : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] PlayerController controller;

    public void OnPointerDown(PointerEventData eventData)
    {
        controller.SetHorizontalInput(1f);
        Debug.Log("Button hold started.");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Button hold ended.");
        controller.SetHorizontalInput(0f);
    }
}
