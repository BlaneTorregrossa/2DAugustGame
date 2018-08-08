using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovement : MonoBehaviour {
    public float speed;
    charMode Mode;

    //Mode of Character Movement 
    enum charMode
    {
        NORMAL = 0, CRAWLING = 1, JUMP
    }

   
    // Use this for initialization
    void Start ()
    {
       speed = 10;
       Mode  = charMode.NORMAL;
    }


	
	// Update is called once per frame
	void Update ()
    {
        //If crouch button is pressed change mode. Check if crawling 
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Mode = charMode.CRAWLING;
        }

        //If crouch button is released change mode.
        if (Input.GetKeyUp(KeyCode.LeftShift))
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
            speed = 6;
        }
        if (Mode == charMode.CRAWLING)
        {
            speed = 2;
        }
        if (Mode == charMode.JUMP)
        {
            
        }

        //if (Input.GetAxis("Horizontal") != 0 && Input.GetAxis("Vertical") != 0)
        //{
        //    x = Input.GetAxis("Horizontal") * Time.deltaTime * speed / 2;
        //    y = Input.GetAxis("Vertical") * Time.deltaTime * speed / 2;
        //}

       

        x = Input.GetAxis("Horizontal") * speed/100;
        y = Input.GetAxis("Vertical")  * speed/100;
        Debug.Log("x: " + x.ToString());
        Debug.Log("y: " + y.ToString());

        transform.Translate(new Vector3(x, y, 0));
    }
}
