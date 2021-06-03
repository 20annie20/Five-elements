using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public Animator transition;
    public float transitionTime = 1f;

    public void LoadNextLevel()
    {
        Statistics stats = Object.FindObjectOfType<Statistics>();
        StartCoroutine(LoadLevel(stats.GetLevel()));
    }
    public void LoadMenu()
    {
        StartCoroutine(LoadLevel(0));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);   
        SceneManager.LoadScene(levelIndex);
    }
}
