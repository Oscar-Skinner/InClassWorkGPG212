using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Input = UnityEngine.Windows.Input;

[RequireComponent(typeof(CharacterController))]
public class Controller : MonoBehaviour
{
    //for the players
    public int playerID;

    //for the player movement
    private CharacterController charControls;
    private Vector3 playerVelocity;
    private bool groundedPlayer;

    [SerializeField] private float playerSpeed = 2.0f;
    [SerializeField] private float jumpHeight = 2f;
    [SerializeField] private float gravityValue = -9.81f;

    private Vector2 movementInput = Vector2.zero;
    private bool jumped = false;
    void Start()
    {
        charControls = gameObject.GetComponent<CharacterController>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        // jumped = context.ReadValue<bool>();
        jumped = context.action.triggered;
    }
    
    void Update()
    {
        groundedPlayer = charControls.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(movementInput.x, 0, 0);
        charControls.Move(move * Time.deltaTime * playerSpeed);

        if (jumped && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        charControls.Move(playerVelocity * Time.deltaTime);
    }
}
