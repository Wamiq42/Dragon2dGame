using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDragonBreathSpawner : MonoBehaviour
{
    public AudioSource fireSound;
    public GameObject playerDragonBreath;
    public GameManager gameManager;
  
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
       

        if(Input.GetKeyDown("space") && gameManager.isGameStarted)
        {
            Instantiate(playerDragonBreath, transform.position, Quaternion.identity);
            if (gameManager.isSoundOn)
            {
                fireSound.Play();
            }
           
        }
    }
}
