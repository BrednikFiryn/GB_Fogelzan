using UnityEngine.AI;
using UnityEngine;

public class EnemyAssignmentComponent : MonoBehaviour
{
    [HideInInspector] public NavMeshAgent[] enemies;
    [HideInInspector] public int enemiesCount;

    private void Start()
    {
        enemiesCount = OverlayEnemyTarget();
    }

    private int OverlayEnemyTarget()
    {
        enemies = FindObjectsOfType<NavMeshAgent>();

        foreach (NavMeshAgent enemy in enemies)
        {
            if (enemy != null)
            {
                enemy.gameObject.AddComponent<EnemyTargetMouse>();
            }
        }

        return enemiesCount = enemies.Length;
    }
}
