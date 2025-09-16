using UnityEngine;

public class HolyWheatCollectable : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private float _forceJumpIncreaseSpeed;
    [SerializeField] private float _resetBoostDuration;
    public void Collect()
    {
        _playerController.SetJumpForce(_forceJumpIncreaseSpeed, _resetBoostDuration);
        Destroy(gameObject);
    }
}
