using System.Collections;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    PlayerInput playerInput;
    Rigidbody2D body2D;

    const Power POWERONE = global::Power.Dash;
    const Power POWERTWO = global::Power.FireArmor;
    const Power POWERNONE = global::Power.None;
    private Vector2 move_input;
    private Vector2 move_dir;
    public bool isGround;
    private bool jump_press;
    private bool power_press;
    private bool canDash;
    private bool isDashing;
    

    public float jumpForce = 10;
    public float dash_force = 20;
    public float dashingTime = 0.2f;
    
    [SerializeField]
    private float moveSpeed = 5;

    Power powerSelected;

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
        powerSelected = global::Power.None;
        isDashing = false;
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

    void UseDash()
    {   

        StartCoroutine(Dash());
    }

    IEnumerator Dash()
    {
        if (canDash)
        {
            canDash = false;
            isDashing = true;
            float originGravity = body2D.gravityScale;
            body2D.gravityScale = 0f;
            body2D.linearVelocityY = 0f;
            body2D.linearVelocity = new Vector2(transform.localScale.x * dash_force, 0f);
            yield return new WaitForSeconds(dashingTime);
            body2D.gravityScale = originGravity;
            isDashing = false;
        }

    }
    void UseFireArmor()
    {
        Debug.Log("Fire Armor active");
    }

    void Power()
    {
        power_press = false;
        switch(powerSelected)
        {
            case global::Power.Dash :
                UseDash();
                break;
            case global::Power.FireArmor :
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

    void SelectPower(Power currentPowerSelected)
    {
        if(currentPowerSelected == powerSelected)
        {
            powerSelected = POWERNONE;
        }
        else
        {
            powerSelected = currentPowerSelected;
        }
    }
    public void OnPowerOne()
    {
		ActivePower?.Invoke(POWERONE);
        SelectPower(POWERONE);
	}
    public void OnPowerTwo()
    {
        ActivePower?.Invoke(POWERTWO);
        SelectPower(POWERONE);
    }
    public void OnUsePower()
    {
        power_press = true;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ground"))
        { 
            isGround = true;
            canDash = true;
        }      
    }

}
