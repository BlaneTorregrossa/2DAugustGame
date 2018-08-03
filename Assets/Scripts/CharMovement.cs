using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovement : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Move Character
        Move();
	}
    
    void Move()
    {
       
            float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
            float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;

            transform.Translate(new Vector3(x, y, 0));
        
    }
}
