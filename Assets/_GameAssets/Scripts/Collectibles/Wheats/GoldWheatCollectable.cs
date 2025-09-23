using UnityEngine;

public class GoldWheatCollectable : MonoBehaviour , ICollectible
{
    [SerializeField] private WheatDesingSO _wheatDesingSO;
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private float _movementIncreaseSpeed;
    [SerializeField] private float _resetBoostTime;
    public void Collect()
    {
        _playerController.SetMovementSpeed(_wheatDesingSO.IncreaseDecreaseMultiplier , _wheatDesingSO.ResetBoostDuration);
        Destroy(gameObject);
    }
}
