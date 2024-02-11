using UnityEngine;

public class ConditionStorage : MonoBehaviour
{
    [SerializeField] private GameObject scythe;
    [SerializeField] private GameObject spirit;
    [SerializeField] private Renderer rend;

    private void Awake()
    {
        rend = scythe.GetComponent<Renderer>();
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
            rend.enabled = false;
        }

        else
        {
            spirit.SetActive(false);
            rend.enabled = true;
        }
    }
}
