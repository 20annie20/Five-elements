using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public int damage = -1;
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Lava!");
        if(other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            if(player != null) {
                Statistics stats = Object.FindObjectOfType<Statistics>();
                stats.SetHealth(damage);
            }
        }
    }
}
