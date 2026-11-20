using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public int coinCounter;
    public TextMeshProUGUI coinCounterText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinCounterText.text = "Coin Coint: " + coinCounter.ToString();
    }
}
