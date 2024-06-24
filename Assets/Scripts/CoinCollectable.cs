using UnityEngine;

public class CoinCollectable : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.CollectCoin();
            Destroy(gameObject);
        }
    }
}
