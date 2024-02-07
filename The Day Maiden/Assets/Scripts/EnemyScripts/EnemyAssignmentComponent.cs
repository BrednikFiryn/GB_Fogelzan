using UnityEngine;

public class EnemyAssignmentComponent : MonoBehaviour
{
    private GameObject[] enemies;

    private void Start()
    {
        OverlayEnemyTarget();
    }

    /// <summary>
    /// ���� �������� � ����� "Enemy" ����������� ��������� EnemyTargetMouse
    /// </summary>
    private void OverlayEnemyTarget()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in enemies)
        {
            if (enemy != null)
            {
                enemy.AddComponent<EnemyTargetMouse>();
                enemy.AddComponent<EnemyAI>();
            }
        }
    }
}
