using UnityEngine;

public class ConditionStorage : MonoBehaviour
{
    [SerializeField] private GameObject scythe;
    [SerializeField] private GameObject matter;
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

    /// <summary>
    /// Проверка персонаж на земле или нет и изменение состояния.
    /// </summary>
    private void ConditionCheck()
    {
        if (Input.GetKey(KeyCode.LeftShift) && !barrierCollision.stop)
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
