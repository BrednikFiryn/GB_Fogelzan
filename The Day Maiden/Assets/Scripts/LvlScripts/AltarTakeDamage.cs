using UnityEngine;
using UnityEngine.UI;

public class AltarTakeDamage : MonoBehaviour
{
    [HideInInspector] public float altarHealth = 1f;
    [SerializeField] private float EnemyDamage;
    [SerializeField] private GameObject altarDeath;
    [SerializeField] private GameObject altarLife;

    [SerializeField] private Image image;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<EnemyAI>())
        {
            altarHealth -= EnemyDamage;
            image.fillAmount = altarHealth;

            if (altarHealth <= 0f)
            {
                altarHealth = 0f;
                altarLife.SetActive(false);
                altarDeath.SetActive(true);
            }
        }
    }
}
