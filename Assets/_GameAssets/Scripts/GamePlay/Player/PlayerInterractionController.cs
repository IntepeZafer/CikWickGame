using UnityEngine;

public class PlayerInterractionController : MonoBehaviour
{
    private PlayerController _playerController;

    void Awake()
    {
        _playerController = GetComponent<PlayerController>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<ICollectible>(out ICollectible collectible))
        {
            collectible.Collect();
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent<IBoostables>(out var boostable))
        {
            boostable.Boost(_playerController);
        }
    }
}
