using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private InputActions inputActions;

    private Vector2 input;
    public Vector2 Input
    {
        get { return input; }
    }

    private bool pressedFire;

    public bool PressedFire
    {
        get { return pressedFire; }
    }

    private void Awake()
    {
        inputActions = new InputActions();

        inputActions.Player.Move.canceled += Move;
        inputActions.Player.Move.started += Move;
        inputActions.Player.Move.performed += Move;

        inputActions.Player.Fire.canceled += Fire;
        inputActions.Player.Fire.started += Fire;
        inputActions.Player.Fire.performed += Fire;
    }

    private void Fire(InputAction.CallbackContext obj)
    {
        pressedFire = obj.ReadValueAsButton();
    }

    private void Move(InputAction.CallbackContext obj)
    {
        input = obj.ReadValue<Vector2>();
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }
}
