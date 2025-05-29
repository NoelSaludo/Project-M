using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{
    [FormerlySerializedAs("moveSpeed")] public float walkSpeed;
    public float sprintSpeed;
    
    private InputAction moveAction;
    private InputAction sprintAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        sprintAction = InputSystem.actions.FindAction("Sprint");
        walkSpeed = 3f;
        sprintSpeed = 1.5f * walkSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = moveAction.ReadValue<Vector3>();
        
        float currSpeed = walkSpeed;

        if (sprintAction.IsPressed()) 
        {
            currSpeed = sprintSpeed;
        }
        
        if (moveAction.IsPressed())
        {
            transform.Translate(movement * (currSpeed * Time.deltaTime));
        }
    }
}
