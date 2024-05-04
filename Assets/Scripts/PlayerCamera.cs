using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private Transform _cam;
    [SerializeField] private float _sensitivity = 10;
    [SerializeField] private float clampAngle = 80f;

    private Rigidbody _rb;
    private float _xRotation;
    private float _yRotation;
        
    private InputAction _look;

    public bool pauseCameraMovement;

/*    private void Update()
    {
        Rotation();
    }
         
    private Vector2 GetMouseInput()
    {
        // Get the x and y movement of the mouse and combine it in one variable
        float mouseX = _look.ReadValue<Vector2>().x;
        float mouseY = _look.ReadValue<Vector2>().y;
        return new Vector2(mouseX, mouseY);
    }*/

/*    private void Rotation()
    {
        // pause movement
        if (pauseCameraMovement) return;
            
        // Y Rotation
        _yRotation += GetMouseInput().x * _sensitivity * Time.deltaTime;
        _rb.rotation = Quaternion.Euler(0f, _yRotation, 0f);

        // X Rotation
        _xRotation -= GetMouseInput().y * _sensitivity * Time.deltaTime;
        Vector3 camEulerAngles = _cam.rotation.eulerAngles;
        _xRotation = Mathf.Clamp(_xRotation, -clampAngle, clampAngle);
        _cam.rotation = Quaternion.Euler(_xRotation, camEulerAngles.y, camEulerAngles.z);
    }*/
}


