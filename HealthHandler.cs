using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthHandler: MonoBehaviour
{
  public TMP_Text HealthText;
  Statistics stats;
  private void Awake() {
    stats = Object.FindObjectOfType<Statistics>();
  }
  
  private void Update() {
      HealthText.text = "Health: " + stats.GetHealth();
  }
}
