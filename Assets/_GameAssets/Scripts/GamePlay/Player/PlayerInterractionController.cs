using UnityEngine;

public class PlayerInterractionController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(Const.WheatTypes.GOLD_WHEAT))
        {
            other.gameObject?.GetComponent<GoldWheatCollectable>().Collect();
        }
        else if(other.CompareTag(Const.WheatTypes.HOLY_WHEAT))
        {
            other.gameObject?.GetComponent<HolyWheatCollectable>().Collect();
        }
        else if(other.CompareTag(Const.WheatTypes.ROTTEN_WHEAT))
        {
            other.gameObject?.GetComponent<RottenWheatCollectable>().Collect();
        }
    }
}
