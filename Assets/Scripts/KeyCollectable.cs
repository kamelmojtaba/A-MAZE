using UnityEngine;

public class KeyCollectable : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.CollectKey();
            Destroy(gameObject);
        }
    }
}
