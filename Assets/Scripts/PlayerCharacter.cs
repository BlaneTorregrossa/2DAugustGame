using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "PlayerCharacter", menuName = "playerCharacter", order = 1)]
public class PlayerCharacter : ScriptableObject {

    public float walkingSpeed;
    public float crawlingSpeed;

}
