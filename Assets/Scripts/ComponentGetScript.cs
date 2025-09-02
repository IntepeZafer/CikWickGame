using UnityEngine;

public class ComponentGetScript : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private SphereCollider _sphereCollider;

    private Transform _transform;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _sphereCollider = GetComponent<SphereCollider>();
        _transform = GetComponent<Transform>();
    }
    void Start()
    {
        _rigidbody.useGravity = false;
        _rigidbody.position = new Vector3(0, 5, 0);
        _sphereCollider.isTrigger = true;
        _transform.localScale = new Vector3(2, 2, 2);
    }
}
