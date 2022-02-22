using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float speed = 6.0f;  //To adjust the speed of our Player
    private Rigidbody2D playerRigidbody;
    private Animator playerDragonAnimator;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerDragonAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayerMovement()
    {
        if (gameManager.isGameStarted)
        {
            //To get the input from player, we get to know which key was pressed either a, left arrow or right arrow,d
            float horizontal = Input.GetAxis("Horizontal");

            //To get the input from player, we get to know which key was pressed either a, left arrow or right arrow,d
            float vertical = Input.GetAxis("Vertical");

            //setting up the direction movements for the Player
            Vector2 direction = new Vector2(horizontal, vertical);

            //normalized keywords is used to give equal speed at different magnitudes.
            playerRigidbody.velocity = direction.normalized * speed;


            //conditions for animator to animate player Dragon
            playerDragonAnimator.SetBool("flyingLeft", horizontal < 0);
            playerDragonAnimator.SetBool("flyingForward", vertical > 0 || horizontal == 0 || vertical == 0);
            playerDragonAnimator.SetBool("flyingRight", horizontal > 0);
            playerDragonAnimator.SetBool("flyingBackward", vertical < 0);
        }
    }
}
