using UnityEngine;

public class ThirdPersonCameraControl : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Transform _orientationTransform;
    [SerializeField] private Transform _playerVisualsTransform;
    [Header("Settings")]
    [SerializeField] private float _rotationSpeed = 1f;

    void Update()
    {
        Vector3 viewDirection = _playerTransform.position - new Vector3(transform.position.x, _playerTransform.position.y, transform.position.z);
        _orientationTransform.forward = viewDirection.normalized;
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        Vector3 inputDirection = _orientationTransform.forward * verticalInput + _orientationTransform.right * horizontalInput;
        if (inputDirection != Vector3.zero)
        {
            _playerVisualsTransform.forward = Vector3.Slerp(_playerVisualsTransform.forward, inputDirection.normalized, Time.deltaTime * _rotationSpeed);
        }
    }
}
