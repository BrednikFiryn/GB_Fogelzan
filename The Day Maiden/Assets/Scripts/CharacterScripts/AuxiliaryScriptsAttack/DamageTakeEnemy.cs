using UnityEngine;

public class DamageTakeEnemy : MonoBehaviour
{
    private AttackDistantTarget attackDistantTarget;
    private EnemyAssignmentComponent enemyAssignment;

    private void Awake()
    {
        attackDistantTarget = FindObjectOfType<AttackDistantTarget>();
        enemyAssignment = FindObjectOfType<EnemyAssignmentComponent>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out EnemyAI enemy))
        {
            attackDistantTarget.target = null;
            other.gameObject.SetActive(false);
            enemyAssignment.enemiesCount--;
        }
    }
}