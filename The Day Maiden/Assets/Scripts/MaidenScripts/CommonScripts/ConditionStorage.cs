using UnityEngine;

public class ConditionStorage : MonoBehaviour
{
    [SerializeField] private GameObject scythe;
    [SerializeField] private GameObject matter;
    [SerializeField] private GameObject spirit;

    private BarrierCollision barrierCollision;
    private GroundCheck groundCheck;


    private void Awake()
    {
        barrierCollision = FindObjectOfType<BarrierCollision>();
        groundCheck = FindObjectOfType<GroundCheck>();
    }

    private void Update()
    {
        ConditionCheck();
    }

    /// <summary>
    /// �������� �������� �� ����� ��� ��� � ��������� ���������.
    /// </summary>
    private void ConditionCheck()
    {
        if (!groundCheck.isGrounded || Input.GetKey(KeyCode.LeftShift) && !barrierCollision.stop)
        {
            matter.SetActive(false);
            spirit.SetActive(true);
            scythe.GetComponent<Renderer>().enabled = false;
        }

        else
        {
            matter.SetActive(true);
            spirit.SetActive(false);
            scythe.GetComponent<Renderer>().enabled = true;
        }
    }
}
