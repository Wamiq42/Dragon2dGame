using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{
    /*
     * This method is used for collision of gameobjects.
     * The gameobject that has this script is called main gameobject for this script
     * to trigger this method another gameobject must be collided with the main gameobject
     * the gameobject that collides with the main game object it is entered as the collision parameter
     * on the parameter we can use different method e.g here we use this method to destroy the colliding gameobject
     */

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Player")
        {
            Destroy(collision.gameObject);
        }
        
    }



}
