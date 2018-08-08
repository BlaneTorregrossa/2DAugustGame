using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AlertStates
{
    PATROL = 0,
    SUSPICIOUS = 1,
    ALERT = 2,
    PURSUE = 3,
}

enum EnemyStates
{
    WALKING = 0,
    SHOOTING = 1,
    PUNCHING = 2,
}


public class EnemyBehaviour : MonoBehaviour {

    public Character CurrentCharacter;
    public List<Node> Nodes;
    public AlertStates AlertState;

    private EnemyStates enemyState;
    private float t;

    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Patrol()
    {
        bool check = false;
        int NodeCount = 0;
        Vector3 lastPosition = new Vector3(0.5f, 0.5f, 0.5f);
        Vector3 nextPosition = new Vector3(0, 0, 0);

        for (int i = 0; i < Nodes.Count; i++)
        {
            if (lastPosition == Nodes[i].Position)
            {
                check = true;
                NodeCount = i;
            }
            else
                check = false;
        }

        if (check == true)
        {
            lastPosition = Nodes[NodeCount].Position;
            nextPosition = Nodes[NodeCount + 1].Position;
        }

        if (check == false)
        {
            NodeCount = 0;
            lastPosition = CurrentCharacter.WorldPos;
            nextPosition = Nodes[NodeCount].Position;
            check = true;
        }   

        t += Time.deltaTime / CurrentCharacter.Speed;
        transform.position = Vector3.Lerp(lastPosition, nextPosition, t);
    }

    //  Can't really do anything with this right now
    public void CreatePatrol()
    {
        //  var tempnode = new Node();
        //  tempnode.Position = 
    }
}
