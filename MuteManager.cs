using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MuteManager : MonoBehaviour
{   
    private bool isMuted;
    public Sprite musicOn;
    public Sprite musicOff;
    public Button b;
    // Start is called before the first frame update
    void Start()
    {
        b = GameObject.FindGameObjectWithTag("Music").GetComponent<Button>();
        isMuted = PlayerPrefs.GetInt("MUTED") == 1;
        AudioListener.pause = isMuted;
        if(isMuted) {
            b.image.sprite = musicOff;
        }
        else
        {
              b.image.sprite = musicOn;  
        }
    }

    public void MutePressed() {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
        PlayerPrefs.SetInt("MUTED", isMuted ? 1 : 0);
        if(isMuted) {
            b.image.sprite = musicOff;
        }
        else
        {
              b.image.sprite = musicOn;  
        }
    }
}
