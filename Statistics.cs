using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statistics : MonoBehaviour
{
    private int coins = 0;
    private int generalHealth = 10;
    private int health = 10;
    private Skin skin = Skin.Black;
    private int whichLevel = 2; //2 is the build index of level 1
    private bool hasKey = false;
    private float speed = 3.5f;
    private int coinsAtLevelEntry = 0;
    public Skin levelSkin = Skin.Black;
    
    public void SetCoins(int amount){
        coins += amount;
    }

    public int GetCoins() {
        return coins;
    }

    public int GetLevelCoins() {
        return coinsAtLevelEntry;
    }

    public void UpgradeHealth(int newHealth){
        generalHealth = newHealth;
    }

    public int GetGeneralHealth(){
        return generalHealth;
    }

    public void SetHealth(int amount){
        health = amount;
    }

    public int GetHealth(){
        return health;
    }

    public Skin GetSkin(){
        return skin;
    }

    public void SetSkin(Skin newSkin)
    {
        skin = newSkin;
    }

    public void PassTheLevel(){
        coinsAtLevelEntry = GetCoins();
        levelSkin = GetSkin();
        whichLevel++;
    }
    
    public int GetLevel(){
        return whichLevel;
    }

    public void SetSpeed(float newSpeed){
        speed = newSpeed;
    }

    public float GetSpeed(){
        return speed;
    }

    public void SetKey(bool newKeyValue){
        hasKey = newKeyValue;
    }

    public bool GetKey(){
        return hasKey;
    }


    public enum Skin
    {
        Black,
        Green,
        Red,
        Blue
    }
}

