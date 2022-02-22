using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireController : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemey" || collision.gameObject.tag == "DragonRedBreath")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            Destroy(gameObject);
           
            if (collision.gameObject.tag != "Border")
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
