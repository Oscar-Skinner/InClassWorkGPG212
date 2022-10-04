using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour
{
    // public GameObject playerLeft;
    // public GameObject playerRight;
    public Players leftPlayer;
    public Players rightPlayer;
    private void OnEnable()
    {
        var mainInputControles = new MainInputControles();

        mainInputControles.Enable();
        
        mainInputControles.InGame.LeftPlayer.performed += LeftPlayerMovement;
        mainInputControles.InGame.RightPlayer.performed += RightPlayerMovement;
        
    }

    private void LeftPlayerMovement(InputAction.CallbackContext obj)
    {
        leftPlayer.MoveDirection = obj.ReadValue<Vector2>();
    }
    private void RightPlayerMovement(InputAction.CallbackContext obj)
    {
        rightPlayer.MoveDirection = obj.ReadValue<Vector2>();
    }
}
