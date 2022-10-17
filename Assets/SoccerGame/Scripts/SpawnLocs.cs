using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnLocs : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] spawnLocations;

    void OnPlayerJoined(PlayerInput playerInput)
    {
        //set player ID, addd one to start at player 1
        playerInput.gameObject.GetComponent<PlayerController>().playerID = 
            playerInput.playerIndex + 1;
        
        //set start spawn of player to use the locations
        playerInput.gameObject.GetComponent<PlayerController>().startPos = 
            spawnLocations[playerInput.playerIndex].position;
    }
}
