using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIscript : MonoBehaviour
{
    public Animator blackAnim;
    public AnimatorOverrideController blueAnim;
    public AnimatorOverrideController greenAnim;
    public AnimatorOverrideController redAnim;

    public LevelLoader loader;
    private Player player;
    public Bomb bomb;
    public GameObject startPoint;
    private Statistics stats;

    private void Awake() {
        player = FindObjectOfType<Player>();
        stats = Object.FindObjectOfType<Statistics>();
    }

    public void LoadMenu()
    {
        loader.LoadMenu();
        stats.SetCoins(stats.GetLevelCoins());
        stats.SetHealth(stats.GetGeneralHealth());
    }

    public void RestartLevel()
    {
        player.transform.position = startPoint.transform.position;
        stats.SetCoins(stats.GetLevelCoins()-stats.GetCoins());
        stats.SetHealth(stats.GetGeneralHealth());
        if(stats.levelSkin == Statistics.Skin.Black)
        {
            blackAnim = GetComponent<Animator>();
        }else if (stats.levelSkin == Statistics.Skin.Green)
        {
            player.GetComponentInChildren<Animator>().runtimeAnimatorController = greenAnim as RuntimeAnimatorController;
        }
        else if (stats.levelSkin == Statistics.Skin.Red)
        {
            player.GetComponentInChildren<Animator>().runtimeAnimatorController = redAnim as RuntimeAnimatorController;
        }
        else {
            player.GetComponentInChildren<Animator>().runtimeAnimatorController = blueAnim as RuntimeAnimatorController;
        }
    }
}
