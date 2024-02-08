using UnityEngine;

public class ConditionStorage : MonoBehaviour
{
    [SerializeField] private GameObject scythe;
    [SerializeField] private GameObject spirit;

    private BarrierCollision barrierCollision;


    private void Awake()
    {
        barrierCollision = FindObjectOfType<BarrierCollision>();
    }

    private void Update()
    {
        ConditionCheck();
    }

    private void ConditionCheck()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            spirit.SetActive(true);
            scythe.GetComponent<Renderer>().enabled = false;
        }

        else
        {
            spirit.SetActive(false);
            scythe.GetComponent<Renderer>().enabled = true;
        }
    }
}
