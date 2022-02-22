using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int livesRemaining = 3;
    private float time;
    private GameObject spawnedPlayer;
    private Camera mainCamera;
    
    public Slider slider;
    public GameObject pausePanel;
    public int killedEnemies;
    public GameObject playerPrefab;
    public Text livesText;
    public Text gameTimer;
    public GameObject waveText;
    public bool isGameWon = false;
    public bool isGameStarted = false;
    public bool isSoundOn = true;
   
    public bool gamePaused = false;

    // Start is called before the first frame update
    void Start()
    {
        spawnedPlayer = GameObject.FindGameObjectWithTag("Player");
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
            PauseGame();
        
        TotalTime();
        LivesRemaining();

        ChangeBackGround();
     
    }


  
    void PauseGame()
    {
        if(!gamePaused)
        {
            gamePaused = true;
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }
         else
        {
            gamePaused = false;
            pausePanel.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void ChangeBackGround()
    {
        if(slider.value == 0)
        {
            mainCamera.backgroundColor = Color.white;
        }
        if(slider.value == 1)
        {
            mainCamera.backgroundColor = Color.cyan;
        }
        if(slider.value == 2)
        {
            mainCamera.backgroundColor = Color.magenta;
        }
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
