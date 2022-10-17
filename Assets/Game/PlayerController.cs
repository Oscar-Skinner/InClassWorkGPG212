using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    //for spawning the player
    public int playerID;
    public Vector3 startPos;
    
    //for player movement
    private Rigidbody rb;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    
    [SerializeField]
    private float playerSpeed = 2.0f;
    [SerializeField]
    private float gravityValue = -9.81f;

    private Vector2 movementInput = Vector2.zero;
    private void Start()
    {
        this.transform.position = startPos;
        rb = gameObject.GetComponent<Rigidbody>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    void Update()
    {
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        
        Vector3 move = new Vector3(movementInput.x, 0, movementInput.y);
        rb.AddRelativeForce(move * playerSpeed);
    }
}
