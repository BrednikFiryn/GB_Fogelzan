using UnityEngine;
using UnityEngine.UI;

public class EnemyCount : MonoBehaviour
{
    private EnemyAssignmentComponent enemyAssignment;
    private Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
        enemyAssignment = FindObjectOfType<EnemyAssignmentComponent>();
    }

    void Update()
    {
        EnemyCounter();
    }

    private void EnemyCounter()
    {
        text.text = enemyAssignment.enemiesCount.ToString();
    }
}
