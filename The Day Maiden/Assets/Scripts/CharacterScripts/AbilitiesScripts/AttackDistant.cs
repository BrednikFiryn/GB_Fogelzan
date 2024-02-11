using UnityEngine;
using UnityEngine.UI;

public class AttackDistant : MonoBehaviour
{
    [SerializeField] private float attackDistantDelay;
    [SerializeField] private GameObject fireBall;
    [SerializeField] private ParticleSystem partSystem;
    [SerializeField] private Image image;
    private AttackDistantTarget attackDistantTarget;
    private float lastAttackTime = float.MinValue;

    private void Start()
    {
        attackDistantTarget = FindObjectOfType<AttackDistantTarget>();
    }

    void Update()
    {
        AttackCheck();
    }

    private void AttackCheck()
    {
        image.fillAmount = (Time.time - lastAttackTime) / attackDistantDelay;
        if (Time.time < lastAttackTime + attackDistantDelay) return;

        fireBall.transform.position = gameObject.transform.position;
        fireBall.GetComponent<ParticleSystem>().Stop();

        // Проверяем возможность атаки по нажатию клавиши и наличию цели
        if (Input.GetKeyDown(KeyCode.Alpha2) && attackDistantTarget.target != null)
        {
            // Устанавливаем позицию удара в позицию цели и запускаем эффект частиц
            fireBall.transform.position = attackDistantTarget.target.transform.position;
            partSystem.Play();
            fireBall.GetComponent<ParticleSystem>().Play();

            lastAttackTime = Time.time;
            image.fillAmount = 0f;
        }
    }
}
