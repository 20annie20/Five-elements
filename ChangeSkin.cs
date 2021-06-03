using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChangeSkin : MonoBehaviour
{
    public AnimatorOverrideController blueAnim;
    public AnimatorOverrideController greenAnim;
    public AnimatorOverrideController redAnim;

    public GameObject shopPanel;
    public GameObject HUDPanel;
    public Player player;

    public Button redButton;
    public Button greenButton;
    public Button blueButton;

    Statistics stats;

    public TMP_Text coinText;

    private void Awake() {
        stats = Object.FindObjectOfType<Statistics>();
    }

    private void Update() {
        coinText.text = "Amount of coins: " + stats.GetCoins();
    }

    public void RedSkin()
    {
        if(stats.GetCoins() >= 70){
            stats.SetCoins(-70);
            player.GetComponentInChildren<Animator>().runtimeAnimatorController = redAnim as RuntimeAnimatorController;
            stats.SetSkin(Statistics.Skin.Red);
            redButton.interactable = false;
        }
    }

    public void BlueSkin()
    {
        if(stats.GetCoins() >= 100){
            stats.SetCoins(-100);
            player.GetComponentInChildren<Animator>().runtimeAnimatorController = blueAnim as RuntimeAnimatorController;
            stats.SetSkin(Statistics.Skin.Blue);
            blueButton.interactable = false;
        }
        //play not enough coins!
    }

    public void GreenSkin()
    {
        if(stats.GetCoins() >= 20){
            stats.SetCoins(-20);
            player.GetComponentInChildren<Animator>().runtimeAnimatorController = greenAnim as RuntimeAnimatorController;
            stats.SetSkin(Statistics.Skin.Green);
            greenButton.interactable = false;
        }
        //play not enough coins!
    }

    public void CloseShop(){
        HUDPanel.SetActive(true);
        shopPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void showNotEnoughMoney(){
        //display panel
        //wait few seconds
        //close panel
    }
}
