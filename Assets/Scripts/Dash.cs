using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class Dash : MonoBehaviour
{
    public float dashStrength = 30f;
    public float dashCoolDown = 1f;
    public float dashTime = 0.50f;
    
    private float dashTimer = 0f;
    private bool isDashing = false;
    
    private InputAction dashAction;
    private InputAction moveAction;
    private Collider collider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dashAction = InputSystem.actions.FindAction("Dash");
        moveAction = InputSystem.actions.FindAction("Move");
        collider = gameObject.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = moveAction.ReadValue<Vector3>();
        
        if (dashAction.IsPressed() && dashTimer >= dashCoolDown)
        {
            isDashing = true;
            dashTimer = 0f;
        }
        else
        {
            dashTimer += Time.deltaTime;
        }
        
        if (isDashing)
        {
            Debug.Log("Dashing");
            DashMovement(movement);
            dashTimer += Time.deltaTime;
            if (dashTimer >= dashTime)
            {
                isDashing = false;
                dashTimer = 0f; // Reset the timer after dashing
            }
        }
    }

    void DashMovement(Vector3 movement)
    {
        Vector3 dashDirection = movement * (dashStrength * Time.deltaTime); // Adjust the dash distance as needed
        transform.position += dashDirection;
    }
}
