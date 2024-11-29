using UnityEngine;
using UnityEngine.EventSystems;

public class Right : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] PlayerController controller;

    public void OnPointerDown(PointerEventData eventData)
    {
        controller.SetHorizontalInput(1f);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        controller.SetHorizontalInput(0f);
    }
}
