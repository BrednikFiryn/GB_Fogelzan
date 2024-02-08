using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpawnPoint : MonoBehaviour
{
    private bool enemySpawn = true;
    private GameObject[] spawnPoints;
    private int countEnemy = 0;
    private EnemyAssignmentComponent enemyAssignmentComponent;

    public float enemySpawnTime;

    private void Awake()
    {
        enemyAssignmentComponent = FindObjectOfType<EnemyAssignmentComponent>();
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
    }

    private void Start()
    {
        StartCoroutine(EnemSpawnPointRandom());
    }

    private IEnumerator EnemSpawnPointRandom()
    {
        while (enemySpawn && countEnemy < enemyAssignmentComponent.enemies.Length)
        {
            GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Transform spawnPointTransform = spawnPoint.transform;
            NavMeshAgent navMeshAgent = enemyAssignmentComponent.enemies[countEnemy];

            navMeshAgent.gameObject.SetActive(true);
            navMeshAgent.transform.position = spawnPointTransform.position;

            if (navMeshAgent != null)
            {
                navMeshAgent.Warp(spawnPointTransform.position);
                navMeshAgent.gameObject.AddComponent<EnemyAI>();
            }

            countEnemy++;
            yield return new WaitForSeconds(enemySpawnTime);
        }
    }
}