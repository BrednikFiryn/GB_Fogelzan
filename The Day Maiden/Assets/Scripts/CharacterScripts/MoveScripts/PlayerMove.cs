using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody _rb;
    private PlayerInput playerInput;
    [HideInInspector] public float move = 10f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        playerInput = FindObjectOfType<PlayerInput>();
    }

    private void FixedUpdate()
    {
        MoveLogic();
    }

    private void MoveLogic()
    {
        _rb.MovePosition(_rb.position + playerInput.movenemtDirection * move * Time.fixedDeltaTime);

        if (playerInput.movenemtDirection != Vector3.zero)
        {
            Quaternion newRotation = Quaternion.LookRotation(playerInput.movenemtDirection);
            _rb.MoveRotation(newRotation);
        }
    }
}
