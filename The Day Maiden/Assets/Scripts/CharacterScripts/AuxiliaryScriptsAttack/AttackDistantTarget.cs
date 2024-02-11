using UnityEngine;

public class AttackDistantTarget : MonoBehaviour
{
    [SerializeField] private Camera cm;
    [HideInInspector] public GameObject target;

    void Update()
    {
        PositionCheck();
    }

    private void PositionCheck()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cm.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                EnemyTargetMouse enemyTarget = hit.collider.gameObject.GetComponent<EnemyTargetMouse>();

                if (enemyTarget != null)
                {
                    target = enemyTarget.gameObject;
                }
            }
        }

        else if (target == null)
        {
            gameObject.transform.position = new Vector3(0, -50, 0);
        }

        else
        {
            gameObject.transform.position = target.transform.position;
        }
    }
}