using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            if(player != null) {
                Statistics stats = Object.FindObjectOfType<Statistics>();
                stats.SetHealth(stats.GetHealth()-1);
                //light the player in red
            }
        }
    }
}
