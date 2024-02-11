using UnityEngine;
using UnityEngine.UI;

public class AltarTakeDamage : MonoBehaviour
{
    [SerializeField] private float EnemyDamage;
    [SerializeField] private GameObject altarDeath;
    [SerializeField] private GameObject altarLife;
    [SerializeField] private Image image;
    [HideInInspector] public float altarHealth = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<EnemyAI>(out var enemyAI))
        {
            altarHealth -= EnemyDamage;
            image.fillAmount = altarHealth;

            if (altarHealth <= 0f)
            {
                altarLife.SetActive(false);
                altarDeath.SetActive(true);
            }
        }
    }
}
