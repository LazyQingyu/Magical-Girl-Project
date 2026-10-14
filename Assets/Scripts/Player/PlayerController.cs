using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    PlayerInput playerInput;
    Rigidbody2D body2D;

    private Vector2 move_input;
    private Vector2 move_dir;
    public bool isGround;
    private bool jump_press;

    public float jumpForce = 10;
    [SerializeField]
    private float moveSpeed = 5;

    public UnityEvent <Power> ActivePower;
    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();

        if (playerInput == null)
        {
            Debug.LogError("Missing an Player Input Component",this);
            enabled = false;
        }

        InputSystem.actions.Disable();
        playerInput.currentActionMap?.Enable();
        body2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        Move();
        JumpPerformed();
        jump_press = false;

    }

    void JumpPerformed()
    {
        if(isGround && jump_press)
        {
            body2D.AddForce(Vector3.up * jumpForce * 50);
            isGround = false;
        }
    }

    void Move()
    {
        body2D.linearVelocityX = move_input.x * moveSpeed;  
    }
    public void OnMove(InputValue value)
    {
        move_input = value.Get<Vector2>();
    }
    public void OnJump()
    {
        jump_press = true;
    }
    public void OnPowerOne(){
		ActivePower?.Invoke(Power.Dash);
	}
    public void OnPowerTwo()
    {
        ActivePower?.Invoke(Power.FireArmor);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ground")){ isGround = true;}      
    }

}
