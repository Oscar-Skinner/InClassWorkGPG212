using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

[RequireComponent(typeof(Rigidbody2D))]
public class Controller : MonoBehaviour
{
    public Weapon playersWeapon;

    private Animator movementAnimator;
    
    //for the players
    public int playerID;

    //for the player movement
    private Rigidbody2D rb;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private Vector2 movementInput = Vector2.zero;
    
    [SerializeField] private float playerSpeed = 3.0f;
    [SerializeField] private float jumpHeight = 6f;
    [SerializeField] private LayerMask jumpableGround;
    
    private BoxCollider2D coll;
    private bool jumped = false;

    private bool moved = false;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        movementAnimator = GetComponent<Animator>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        //move the player
        movementInput = context.ReadValue<Vector2>();
        if (context.performed)
        {
            moved = true;
        }
        else if (context.canceled)
        {
            moved = false;
        }
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        //if its grounded then allow the player to jump
        if (IsGrounded() == true)
        {
            jumped = true;
        }
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        playersWeapon.shoot();
    }

    private bool IsGrounded()
    {
        //create a box to detect whether the player is standing on the ground or not.
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }

    void Update()
    {
        //for the player movement left and right.
        Vector3 move = new Vector3(movementInput.x, 0, 0);
        rb.AddRelativeForce(move * playerSpeed);
        
        //if jumped is true then make the players rb jump.
        if (jumped == true)
        {
            rb.AddRelativeForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            movementAnimator.SetTrigger("Jump");
            jumped = false;
        }
        
        if (moved == true)
        {
            movementAnimator.SetBool("isRunning", true);
        }
        else
        {
            movementAnimator.SetBool("isRunning", false);
        }
    }
}
