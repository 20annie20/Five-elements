using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            if(player != null) {
                Statistics stats = Object.FindObjectOfType<Statistics>();
                stats.SetKey(true);
                Destroy(this.gameObject);
            }
        }
    }
}
