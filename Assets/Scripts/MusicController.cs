using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public GameManager gameManager;
    public Toggle toggle;
    private AudioSource musicSource;
    
    // Start is called before the first frame update
    void Start()
    {
        musicSource = GetComponent<AudioSource>();
    }

  
    public void CheckMusicOnOff()
    {
        if (!toggle.isOn)
        {
            musicSource.Stop();
        }
        else
            musicSource.Play();

    }
}
