using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject shopPanel;
    public GameObject HUDPanel;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            if(player != null) {
                showPanel(shopPanel, HUDPanel);
            }
        }
    }

    public void showPanel(GameObject yourObjectA, GameObject yourObjectB){
        yourObjectA.SetActive(true);
        yourObjectB.SetActive(false);
        Time.timeScale = 0f;
    }   
}
