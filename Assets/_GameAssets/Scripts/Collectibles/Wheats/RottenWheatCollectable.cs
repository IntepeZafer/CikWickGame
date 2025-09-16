using UnityEngine;

public class RottenWheatCollectable : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private float _movementDecreaseSpeed;
    [SerializeField] private float _resetBoostTime;
    public void Collect()
    {
        _playerController.SetMovementSpeed(_movementDecreaseSpeed, _resetBoostTime);
        Destroy(gameObject);
    }
}
