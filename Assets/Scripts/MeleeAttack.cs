using UnityEngine;
using UnityEngine.InputSystem;

public class MeleeAttack : MonoBehaviour
{
    public float atkSpeed = 0.25f;

    private float _timer = 0;
    private bool _isAttacking = false;

    private InputAction _action;

    private GameObject _attackBox;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _action = InputSystem.actions.FindAction("Attack");
        _attackBox = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (_action.IsPressed())
        {
            Debug.Log("isAttacking");
            _isAttacking = true;
            _attackBox.SetActive(_isAttacking);
        }

        if (_isAttacking) {
            _timer += Time.deltaTime;
            if (_timer >= atkSpeed)
            {
                _isAttacking = false;
                _attackBox.SetActive(_isAttacking);
            }
        }
    }
}