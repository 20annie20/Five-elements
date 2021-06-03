using UnityEngine;
using UnityEngine.SceneManagement;

public class DDOL: MonoBehaviour
{
    public void Awake() {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(1);
    }
}