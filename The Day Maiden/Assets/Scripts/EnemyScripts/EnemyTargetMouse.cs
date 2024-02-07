using UnityEngine;

public class EnemyTargetMouse : MonoBehaviour
{
    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    /// <summary>
    /// Изменения цвета обьекта при наведении мыши
    /// </summary>
    private void OnMouseEnter()
    {
       renderer.material.color = Color.red;
    }

    /// <summary>
    /// Изменения цвета обьекта при отведения мыши с обьета
    /// </summary>
    private void OnMouseExit()
    {
       renderer.material.color = Color.white;
    }
}
