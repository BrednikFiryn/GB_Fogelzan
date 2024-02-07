using UnityEngine;

public class EnemyTargetMouse : MonoBehaviour
{
    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    /// <summary>
    /// ��������� ����� ������� ��� ��������� ����
    /// </summary>
    private void OnMouseEnter()
    {
       renderer.material.color = Color.red;
    }

    /// <summary>
    /// ��������� ����� ������� ��� ��������� ���� � ������
    /// </summary>
    private void OnMouseExit()
    {
       renderer.material.color = Color.white;
    }
}
