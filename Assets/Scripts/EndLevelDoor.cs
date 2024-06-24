using UnityEngine;

public class EndLevelDoor : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.instance.HasKey)
            {
                // Logic to open the door
                GameManager.instance.ShowWinMessage();
                Debug.Log("Door opened. You win!");
            }
            else
            {
                // Display message that the key is needed
                GameManager.instance.ShowKeyMessage();
                Debug.Log("You need a key to open this door.");
            }
        }
    }
}
