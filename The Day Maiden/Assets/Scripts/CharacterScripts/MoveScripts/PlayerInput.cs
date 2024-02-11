using UnityEngine;

public class PlayerInput : MonoBehaviour
{
     [HideInInspector] public float vInput;
     [HideInInspector] public float hInput;
     [HideInInspector] public Vector3 movenemtDirection;

    private void Update()
    {
        InputCheck();
    }

    private void InputCheck()
    {
        vInput = Input.GetAxis("Vertical");
        hInput = Input.GetAxis("Horizontal");
        movenemtDirection = new Vector3(hInput, 0f, vInput).normalized;
    }
}
