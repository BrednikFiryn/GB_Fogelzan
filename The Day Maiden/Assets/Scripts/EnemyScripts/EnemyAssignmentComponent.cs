using UnityEngine.AI;
using UnityEngine;

public class EnemyAssignmentComponent : MonoBehaviour
{
    [HideInInspector] public NavMeshAgent[] enemies;

    private void Start()
    {
        OverlayEnemyTarget();
    }

    private void OverlayEnemyTarget()
    {
        enemies = FindObjectsOfType<NavMeshAgent>();

        foreach (NavMeshAgent enemy in enemies)
        {
            if (enemy != null)
            {
                enemy.gameObject.AddComponent<EnemyTargetMouse>();
            }
        }
    }
}
