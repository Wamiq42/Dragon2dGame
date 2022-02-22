using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightMovingController : MonoBehaviour
{
    public Vector2 StraightMovingspeed;
    private Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            rigidbody2d.velocity = StraightMovingspeed;
        }
        else
        {
            rigidbody2d.velocity = StraightMovingspeed * 0;
        }
    }
}
