using UnityEngine;

public class PlayerMove : MonoBehaviour
{
   [SerializeField] public float move = 10f;

    private Rigidbody _rb;
    private PlayerInput playerInput;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        playerInput = FindObjectOfType<PlayerInput>();
    }

    private void FixedUpdate()
    {
        MoveLogic();
    }

    /// <summary>
    /// Движение и поворот.
    /// </summary>
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
