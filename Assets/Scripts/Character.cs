using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Game Objects/Character")]
public class Character : ScriptableObject
{
    public float Speed;
    public Vector3 WorldPos;
}
