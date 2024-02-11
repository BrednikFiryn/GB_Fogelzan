using UnityEngine;

public class AttackMeleeTarget : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out EnemyAI target))
        {
            other.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out EnemyAI target))
        {
            other.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
