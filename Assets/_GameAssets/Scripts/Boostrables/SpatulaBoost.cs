using UnityEngine;

public class SpatulaBoost : MonoBehaviour, IBoostables
{
    [Header("Referances")]
    [SerializeField] private Animator _spatulaAnimator;
    [Header("Boost Settings")]
    [SerializeField] private float jumpForce;
    private bool _isAcivated;
    public void Boost(PlayerController playerController)
    {
        if (_isAcivated) return;
        PlayBoostAnimation();
        Rigidbody playerRigidbody = playerController.GetPlayerRigidbody();
        playerRigidbody.linearVelocity = new Vector3(playerRigidbody.linearVelocity.x, 0f, playerRigidbody.linearVelocity.z);
        playerRigidbody.AddForce(transform.forward * jumpForce, ForceMode.Impulse);
        _isAcivated = true;
        Invoke(nameof(ResetActivation), 0.2f);
    }
    private void PlayBoostAnimation()
    {
        _spatulaAnimator.SetTrigger(Const.OtherAnimations.IS_SPATULA_JUMPING);
    }
    private void ResetActivation()
    {
        _isAcivated = false;
    }
}
