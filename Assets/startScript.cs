using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonEffects : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private RectTransform rectTransform; // RectTransform del botón
    private Vector3 originalScale;       // Escala original del botón
    public float scaleMultiplier = 2f;  // Multiplicador de escalado (por defecto 2x)

    void Start()
    {
        // Obtener el RectTransform del botón
        rectTransform = GetComponent<RectTransform>();

        // Guardar la escala original
        originalScale = rectTransform.localScale;
    }

    // Cuando el cursor entra en el botón
    public void OnPointerEnter(PointerEventData eventData)
    {
        rectTransform.localScale = originalScale * scaleMultiplier; // Escala aumentada
    }

    // Cuando el cursor sale del botón
    public void OnPointerExit(PointerEventData eventData)
    {
        rectTransform.localScale = originalScale; // Restaurar escala original
    }
}
