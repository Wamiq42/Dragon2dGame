using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonResetScript : MonoBehaviour
{
    public GameObject buttonReset;
    private GameManager gameManager;
    private int lives;
 
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {
        
        if(gameManager.ReturnLivesRemaining() == 0)
        {
            buttonReset.SetActive(true);
            
            
        }
    }


}