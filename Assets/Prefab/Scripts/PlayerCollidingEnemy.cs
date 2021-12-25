using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCollidingEnemy : MonoBehaviour
{
    //public GameObject resetButton;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemey")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            //resetButton.SetActive(true);
        }

    }
    private void Update()
    {
        
        
            
        
        
    }

}
