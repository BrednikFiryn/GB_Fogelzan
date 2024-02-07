using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    [HideInInspector] public bool isGrounded;
    [SerializeField] private float maxDistance;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private GameObject scythe;

    void Update()
    {
        IsGorund();
    }

    private void IsGorund()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, maxDistance, groundMask);
    }
}

