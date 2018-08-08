using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovement : MonoBehaviour {
   
    charMode Mode;

    public PlayerCharacter playerCharacter;
    private float currentSpeed;

  
   

    //Mode of Character Movement  ADD SPRINT
    enum charMode
    {
        NORMAL = 0, CRAWLING = 1, SPRINT = 2
    }

   
    // Use this for initialization
    void Start ()
    {
   
       Mode  = charMode.NORMAL;
    }


	
	// Update is called once per frame
	void Update ()
    {
        //If crouch button is pressed change mode. Check if crawling 
        if (Input.GetKeyDown(KeyCode.LeftShift) && Mode != charMode.CRAWLING)
        {
            Mode = charMode.CRAWLING;
        }

        //If crouch button is released change mode.
        if (Input.GetKeyUp(KeyCode.LeftShift) && Mode == charMode.CRAWLING)
        {
            Mode = charMode.NORMAL;
        }

        //Translate at speed based on Mode.
        Move();
	}
    
    void Move()
    {
        float x = 0;
        float y = 0;


        if (Mode == charMode.NORMAL)
        {
            currentSpeed = playerCharacter.walkingSpeed;
        }
        if (Mode == charMode.CRAWLING)
        {
            currentSpeed = playerCharacter.crawlingSpeed;
        }

        float nspeed = currentSpeed / 100;
       

        x = Input.GetAxis("Horizontal") * nspeed;
        y = Input.GetAxis("Vertical")  * nspeed;
        transform.Translate(new Vector3(x, y, 0));
    }
}
