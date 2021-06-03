using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 1;
    public AudioClip coinSound;

    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            if(player != null) {
                Statistics stats = Object.FindObjectOfType<Statistics>();
                stats.SetCoins(value);
                AudioSource.PlayClipAtPoint(coinSound, transform.position, 1.3f);
                Destroy(this.gameObject);
            }
        }
    }
}
