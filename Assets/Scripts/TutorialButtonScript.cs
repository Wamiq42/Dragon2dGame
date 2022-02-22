using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialButtonScript : MonoBehaviour
{

    public GameObject mainMenuPanel;
    public GameObject tutorialPanel;
   

    public void StartTutorialPanel()
    {

        tutorialPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
    }
}
