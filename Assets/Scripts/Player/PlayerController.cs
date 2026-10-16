using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    PlayerInput playerInput;
    Rigidbody2D body2D;

    [SerializeField] LayerMask layerMaskGround;
    [SerializeField] Animator player_animator;
    [SerializeField] SpriteRenderer playerSprite;

    private float rayCastSize = 1.5f;
    const Power POWERONE = global::Power.Dash;
    const Power POWERTWO = global::Power.FireArmor;
    const Power POWERNONE = global::Power.None;
    private Vector2 move_input;

    public bool isGrounded;
    private bool jump_press;
    private bool power_press;
    private bool isDashing;
    private bool isFireArmor = false;    

    public float jumpForce = 10;
    public float dash_force = 20;
    public float dashingTime = 0.2f;
    
    [SerializeField]
    private float moveSpeed = 5;

    Power powerSelected;

    public UnityEvent <Power> ActivePower;
    public UnityEvent <bool> FireArmorStatus;
    public UnityEvent HitByFire;
    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();

        layerMaskGround = LayerMask.GetMask("Ground");

        if (playerInput == null)
        {
            Debug.LogError("Missing an Player Input Component",this);
            enabled = false;
        }

        InputSystem.actions.Disable();
        playerInput.currentActionMap?.Enable();
        body2D = GetComponent<Rigidbody2D>();
        powerSelected = global::Power.None;
        isDashing = false;
    }

    void Update()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, rayCastSize , layerMaskGround);
        player_animator.SetBool("isGrounded", isGrounded);
        player_animator.SetBool("Run", (move_input.x == 0)? false : true);
        FlipPlayer();
    }

    void FlipPlayer()
    {
        if (move_input.x < 0)
        {
            playerSprite.flipX = true;
        }
        else if (move_input.x > 0)
        {
            playerSprite.flipX = false;
        }
    }
    void FixedUpdate()
    {
        
    
        if(isDashing)return;
        Move();
        JumpPerformed();
        jump_press = false;

        if (power_press)
        {
            Power();
        }
        if(isFireArmor && powerSelected != POWERTWO)
        {
            ActivateFireArmor(false);
        }
    }

    void JumpPerformed()
    {
        if(isGrounded && jump_press)
        {
            body2D.AddForce(Vector3.up * jumpForce * 50);
            isGrounded = false;
        }
    }

    void Move()
    {
        body2D.linearVelocityX = move_input.x * moveSpeed;
    }

    void UseDash()
    {   

        StartCoroutine(Dash());
    }

    IEnumerator Dash()
    {
        if (!isGrounded)
        {
            isDashing = true;
            float originGravity = body2D.gravityScale;
            body2D.gravityScale = 0f;
            body2D.linearVelocityY = 0f;
            body2D.linearVelocity = new Vector2(transform.localScale.x * move_input.x * dash_force, 0f);
            yield return new WaitForSeconds(dashingTime);
            body2D.gravityScale = originGravity;
            isDashing = false;
        }

    }
    void UseFireArmor()
    {
        ActivateFireArmor(!isFireArmor);
    }

    void ActivateFireArmor(bool status)
    {
        FireArmorStatus?.Invoke(status);
        isFireArmor = status;
    }


    void Power()
    {
        power_press = false;
        switch(powerSelected)
        {
            case POWERONE :
                UseDash();
                break;
            case POWERTWO :
                UseFireArmor();
                break;
        }
    }
    public void OnMove(InputValue value)
    {
        move_input = value.Get<Vector2>();
    }
    public void OnJump()
    {
        jump_press = true;
    }
    Power SelectPower(Power currentPowerSelected)
    {
        if(currentPowerSelected == powerSelected)
        {
            ActivePower?.Invoke(POWERNONE);
            return POWERNONE;
        }
        else
        {
            ActivePower?.Invoke(currentPowerSelected);
            return currentPowerSelected;
        }
    }
    public void OnPowerOne()
    {        
        ActivateFireArmor(false);
        powerSelected = SelectPower(POWERONE);
	}
    public void OnPowerTwo()
    {
        powerSelected = SelectPower(POWERTWO);
    }
    public void OnUsePower()
    {
        power_press = true;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
    

        if (collision.CompareTag("Fire"))
        {
            if (!isFireArmor)
            {
                Debug.Log("I'm in Fire heheh");
                HitByFire?.Invoke();
            }
        }
    }

}
