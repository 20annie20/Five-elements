using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public AudioClip bombSound;
    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Enemy"){
            Enemy enemy = other.GetComponent<Enemy>();

            if(enemy != null)
            {
                //start animation of explosion
                //Destroy(other)
                AudioSource.PlayClipAtPoint(bombSound, transform.position, 1.3f);
                //disable the sprite
                //spam a coin
                Destroy(this.gameObject);
            }
            
        }
    }
}
