using System.Collections;
using UnityEngine;

public class GameWinDefeat : MonoBehaviour
{
    [SerializeField] private float endTime;
    [SerializeField] private GameObject[] interfaces;
    private AltarTakeDamage altarDamage;
    private EnemyAssignmentComponent enemyAssignment;

    private void Awake()
    {
        enemyAssignment = FindObjectOfType<EnemyAssignmentComponent>();
        altarDamage = FindObjectOfType<AltarTakeDamage>();
    }

    void Update()
    {
        CheckAltarHealth();
    }

    private void CheckAltarHealth()
    {
        foreach (GameObject inface in interfaces)
        {
            if (altarDamage.altarHealth <= 0f || enemyAssignment.enemiesCount == 0f)
            {
                interfaces[0].SetActive(false);
                StartCoroutine(EndGamehRoutine());   
            }        
        }
    }

    private IEnumerator EndGamehRoutine()
    {
        yield return new WaitForSeconds(endTime);
        Time.timeScale = 0f;

        if (altarDamage.altarHealth <= 0f)
        {
            interfaces[1].SetActive(true);
        }

        else if (enemyAssignment.enemiesCount == 0f)
        {
            interfaces[2].SetActive(true);
        }
    }
}
