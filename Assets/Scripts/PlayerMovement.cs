using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private InputAction moveAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = moveAction.ReadValue<Vector3>();
        if (moveAction.IsPressed())
        {
            transform.Translate(movement * (moveSpeed * Time.deltaTime));
        }
    }
}
