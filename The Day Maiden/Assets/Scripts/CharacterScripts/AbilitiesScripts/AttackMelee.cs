using UnityEngine;
using UnityEngine.UI;

public class AttackMelee : MonoBehaviour
{
    [SerializeField] private float attackMeleeDelay;
    [SerializeField] private Image image;
    private Animator anim;
    private Collider col;
    private float lastAttackTime = float.MinValue;

    private void Awake()
    {
        col = GetComponent<Collider>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        AttackMeleeCheck();
    }

    private void AttackMeleeCheck()
    {
        // Обновляем заполнение изображения, показывающего готовность к атаке
        image.fillAmount = (Time.time - lastAttackTime) / attackMeleeDelay;
        if (Time.time < lastAttackTime + attackMeleeDelay)
        return;

        if (Input.GetKeyDown(KeyCode.Alpha1) && !Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetTrigger("Attack");
            col.enabled = true;
            lastAttackTime = Time.time;
            image.fillAmount = 0f;
        }

        else
        {
            col.enabled = false;
        }
    }
}
