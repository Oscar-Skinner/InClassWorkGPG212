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
        MainInputControles mainInputControles = new MainInputControles();
        mainInputControles.Enable();
        
        mainInputControles.InGame.LeftPlayer.performed += LeftPlayerMovement;
        mainInputControles.InGame.RightPlayer.performed += RightPlayerMovement;
        mainInputControles.InGame.LeftPlayer.canceled += LeftPlayerMovement;
        mainInputControles.InGame.RightPlayer.canceled += RightPlayerMovement;
    }

    private void LeftPlayerMovement(InputAction.CallbackContext obj)
    {
        if (obj.started)
        {
            leftPlayer.MoveDirection = obj.ReadValue<Vector2>();
        }
        else if (obj.canceled)
        {
            leftPlayer.MoveDirection = obj.ReadValue<Vector2>();
        }
    }
    private void RightPlayerMovement(InputAction.CallbackContext obj)
    {
        if (obj.performed)
        {
            rightPlayer.MoveDirection = obj.ReadValue<Vector2>();
        }
        else if (obj.canceled)
        {
            rightPlayer.MoveDirection = obj.ReadValue<Vector2>();
        }
    }

}
