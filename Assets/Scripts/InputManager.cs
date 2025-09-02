using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private GameObject _sphereGameObject;


    void Awake()
    {
        _sphereGameObject.GetComponent<EnableDisabled>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _sphereGameObject.GetComponent<Collider>().isTrigger = !_sphereGameObject.GetComponent<Collider>().isTrigger;
        }
    }
}
