using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Statistics stats = Object.FindObjectOfType<Statistics>();
            Debug.Log("Next level!: " +  stats.GetLevel());
            stats.PassTheLevel();
            SceneManager.LoadScene(stats.GetLevel());
        }
    }
}