using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int totalCoins;
    private int coinsCollected = 0;
    private bool hasKey = false;

    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI keyText;
    public GameObject keyMessage;
    public GameObject winMessage; 
    public TextMeshProUGUI coinCountText;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        UpdateHUD();
        keyMessage.SetActive(false);
        winMessage.SetActive(false);
    }

    public void CollectCoin()
    {
        coinsCollected++;
        UpdateHUD();
    }

    public void CollectKey()
    {
        hasKey = true;
        UpdateHUD();
    }
    public bool HasKey
    {
        get { return hasKey; }
    }

    public void ShowKeyMessage()
    {
        StartCoroutine(ShowKeyMessageCoroutine());
    }

    private IEnumerator ShowKeyMessageCoroutine()
    {
        keyMessage.SetActive(true);
        yield return new WaitForSeconds(5);
        keyMessage.SetActive(false);
    }
    public void ShowWinMessage()
    {
        winMessage.SetActive(true);
        coinCountText.text = "Coins Collected: " + coinsCollected;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void UpdateHUD()
    {
        coinsText.text = "Coins: " + coinsCollected + "/" + totalCoins;
        keyText.text = "Key: " + (hasKey ? "1" : "0");
    }
}
