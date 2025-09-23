using UnityEngine;

public class RottenWheatCollectable : MonoBehaviour , ICollectible
{
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private float _movementDecreaseSpeed;
    [SerializeField] private float _resetBoostTime;
    [SerializeField] private WheatDesingSO _wheatDesingSO;
    public void Collect()
    {
        _playerController.SetMovementSpeed(-_wheatDesingSO.IncreaseDecreaseMultiplier , _wheatDesingSO.ResetBoostDuration);
        Destroy(gameObject);
    }
}
