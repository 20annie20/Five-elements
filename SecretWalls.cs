using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretWalls : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Wall!");
        if(other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            if(player != null) {
                Statistics stats = Object.FindObjectOfType<Statistics>();
                Debug.Log(stats.GetKey());
                if(stats.GetKey() == true) 
                {
                    Destroy(this.gameObject);
                }
                else
                //TODO dodać podpis
                Debug.Log("You need a key!");
            }
        }
    }
}
