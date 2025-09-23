using UnityEngine;

public class PlayerInterractionController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<ICollectible>(out ICollectible collectible))
        {
            collectible.Collect();
        }
    }
}
