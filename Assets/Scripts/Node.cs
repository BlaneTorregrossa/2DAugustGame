using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Node", menuName = "Hidden Objects/Node")]
public class Node : ScriptableObject
{
    public Vector3 Position;

    public static implicit operator Vector3(Node v)
    {
        throw new NotImplementedException();
    }
}
