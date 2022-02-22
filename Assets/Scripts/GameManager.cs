using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int livesRemaining = 3;
    private float time;
    private GameObject spawnedPlayer;
    

    
    public int killedEnemies;
    public GameObject playerPrefab;
    public Text livesText;
    public Text gameTimer;
    public GameObject waveText;
    public bool isGameWon = false;
    public bool isGameStarted = false;
    public bool isSoundOn = true;

    // Start is called before the first frame update
    void Start()
    {
        spawnedPlayer = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        KilledEnemies();
        TotalTime();
        LivesRemaining();
     
    }

    void KilledEnemies()
    {
        //Debug.Log(killedEnemies);
    }
    

    public void setSoundOnOff(bool onOff)
    {
        isSoundOn = onOff;
    }
    void LivesRemaining()
    {
        if (spawnedPlayer == null && livesRemaining != 0 && isGameStarted)
        {
            livesRemaining -= 1;
            livesText.text = "Lives : " + livesRemaining;
            spawnedPlayer = Instantiate(playerPrefab, transform.position, Quaternion.identity);
        }
    }


    void TotalTime()
    {
        if (spawnedPlayer != null && livesRemaining != 0 && !isGameWon && isGameStarted) 
        {
            time += Time.deltaTime;
            //Debug.Log(time);
            float minutes = Mathf.Floor(time / 60);
            float seconds = Mathf.RoundToInt(time % 60);
            gameTimer.text = minutes.ToString() + " : " + seconds.ToString();
        }
    }

    public int ReturnLivesRemaining()
    {
        return livesRemaining;
    }
}
