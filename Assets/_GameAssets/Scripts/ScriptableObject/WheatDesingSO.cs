using UnityEngine;
[CreateAssetMenu (fileName = "WheatDesingSO", menuName = "ScriptableObjects/WheatDesingSO", order = 1)]
public class WheatDesingSO : ScriptableObject
{
    [SerializeField] private float _increaseDecreaseMultiplier;
    [SerializeField] private float _resetBoostDuration;

    public float IncreaseDecreaseMultiplier => _increaseDecreaseMultiplier;
    public float ResetBoostDuration => _resetBoostDuration;
}
