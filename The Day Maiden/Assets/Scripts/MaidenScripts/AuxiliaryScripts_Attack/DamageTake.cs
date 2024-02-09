using UnityEngine;

public class DamageTake : MonoBehaviour
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
        if (other.gameObject.CompareTag("Enemy"))
        {
            attackDistantTarget.target = null;
            other.gameObject.SetActive(false);
            enemyAssignment.enemiesCount--;
        }
    }
}