using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;


public class PlayerJump : MonoBehaviour
{
    private Rigidbody rb;
    private InputActions input;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        input = new InputActions();
        input.Player.Enable();
        input.Player.Jump.performed += Jump_performed;
    }

    private void Jump_performed(UnityEngine.InputSystem.InputAction.CallbackContext content)
    {
        rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);

    }

    void FixedUpdate()
    {

        //Vector3 movement = new Vector3(0.0f, movementZ, 0.0f);

        //rb.AddForce(movement * speed);

    }

}