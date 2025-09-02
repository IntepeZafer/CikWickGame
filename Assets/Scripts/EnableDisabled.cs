using UnityEngine;

public class EnableDisabled : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("Enabled");
    }
    private void OnDisable()
    {
        Debug.Log("Disabled");
    }
}
