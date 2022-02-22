using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningRandomEnemey : MonoBehaviour
{
    public GameObject[] DragonandBomber;
    public float interval = 2.0f;

    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawningRandom", interval, interval);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        if (gameManager.isGameWon && interval != 0)
        {
            interval -= 1.0f;
            gameManager.isGameWon = false;
            gameManager.waveText.SetActive(false);
        }
    }

    /*
     * The spawingRandom doesnt take any gameobject or any datatype as parametes nethere returns anything.
     * this function only instantiates (cloning of objects) the gameobjects at specific location or position. 
     */
    private void spawningRandom()
    {
        float randomNum = Random.value;

        if (GameObject.FindWithTag("Player") != null)
        {
            if (randomNum < 0.2)
            {
                GameObject randomEnemy = Instantiate(DragonandBomber[0], transform.position, Quaternion.identity);
            }
            else if (randomNum < 0.4)
            {
                GameObject randomEnemy = Instantiate(DragonandBomber[1], transform.position, Quaternion.identity);
            }
            else
            {
                //spawn nothing;
            }
        }
        else
        {
            //spawn nothing;
        }

    }
}