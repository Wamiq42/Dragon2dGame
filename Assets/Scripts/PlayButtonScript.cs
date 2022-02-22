using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonScript : MonoBehaviour
{
    public bool isGameStarted = false;
    public GameObject mainMenuPanel;
    public GameManager gameManager;

    public void StartGame()
    {
        isGameStarted = true;
        gameManager.isGameStarted = isGameStarted;
        mainMenuPanel.SetActive(false);
    }
}
