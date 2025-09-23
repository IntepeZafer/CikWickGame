using UnityEngine;

public class HolyWheatCollectable : MonoBehaviour , ICollectible
{
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private float _forceJumpIncreaseSpeed;
    [SerializeField] private float _resetBoostDuration;
    [SerializeField] private WheatDesingSO _wheatDesingSO;
    public void Collect()
    {
        _playerController.SetJumpForce(_wheatDesingSO.IncreaseDecreaseMultiplier , _wheatDesingSO.ResetBoostDuration);
        Destroy(gameObject);
    }
}
