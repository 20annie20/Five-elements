using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinHandler: MonoBehaviour
{
  public TMP_Text CoinText;
  Statistics stats;
  private void Awake() {
    stats = Object.FindObjectOfType<Statistics>();
  }
  
  private void Update() {
      CoinText.text = "Coins: " + stats.GetCoins();
  }
}
