using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDragonBreathController : MonoBehaviour
{
    private int killedEnemies = 0;


    private void Start()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().killedEnemies = killedEnemies;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "RedDragonBreath")
        {
            Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());

        }
        else
        {
            Destroy(gameObject);
            if(collision.gameObject.tag != "Border")
            {
                Destroy(collision.gameObject);
                killedEnemies += 1;
                Debug.Log("RBC killed " + killedEnemies);
            }
        }
    }

    public int getKilledEnemies()
    {
        return killedEnemies;
    }
}
