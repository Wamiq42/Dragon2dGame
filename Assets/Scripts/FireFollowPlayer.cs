using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFollowPlayer : MonoBehaviour
{
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

        GameObject playerTagged = GameObject.FindWithTag("Player");

        /*
         * playerDragonLocation determines the location to where the firebomb must travel in our game it will be
         * towards player location.
         * Vector2 gives us the cordinates in 2 dimension
         * gameobject must not be null to or else it will give an exception
         */

        if(playerTagged != null)
        {
            Vector2 playerDragonLocation = (playerTagged.transform.position - transform.position).normalized;
            GetComponent<Rigidbody2D>().velocity = playerDragonLocation * speed;
        }
       
        else
        {
            Destroy(gameObject);
        }    
       
        


    }


}
