using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDragonBreathController : MonoBehaviour
{
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
            }
        }
    }
}
