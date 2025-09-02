using UnityEngine;

public class CollisionTrigger : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with " + collision.gameObject.name);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered by " + other.gameObject.name);
    }
}
