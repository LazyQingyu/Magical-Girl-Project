using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class Joueur : MonoBehaviour
{
	public float angle = 45.0f;
	private SpriteRenderer spriteRenderer;
	public float vitesse = 100.0f;
	public float rotation = 5.0f;
	private Rigidbody2D rb;
	public float jumpForce = 20.0f;
	public LayerMask groundLayer;
	public Transform groundCheck;
	private bool isGrounded;
	public bool active_saut = false;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
		rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
		
		float rotationX = Input.GetAxis("Horizontal") * angle;
		Quaternion cible = Quaternion.Euler (rotationX, 0, 0); 
		
			if(Input.GetKey(KeyCode.RightArrow)){
				transform.Translate(Vector3.right * Time.deltaTime * vitesse);
				transform.rotation = Quaternion.Slerp (transform.rotation, cible, Time.deltaTime * rotation);
				spriteRenderer.flipX = true;
				spriteRenderer.flipY = false;
			}
			if(Input.GetKey(KeyCode.LeftArrow)){
				transform.rotation = Quaternion.Slerp (transform.rotation, cible, Time.deltaTime * rotation);
				transform.Translate(Vector3.left * Time.deltaTime * vitesse);
				spriteRenderer.flipX = false;
				spriteRenderer.flipY = false;
			}
			if(Input.GetKey(KeyCode.A)){
				transform.rotation = Quaternion.Slerp (transform.rotation, cible, Time.deltaTime * rotation);
				transform.Translate(Vector3.left * Time.deltaTime * vitesse);
				spriteRenderer.flipX = true;
				spriteRenderer.flipY = false;
			}
			if(Input.GetKey(KeyCode.D)){
				transform.rotation = Quaternion.Slerp (transform.rotation, cible, Time.deltaTime * rotation);
				transform.Translate(Vector3.right * Time.deltaTime * vitesse);
				spriteRenderer.flipX = false;
				spriteRenderer.flipY = false;
			}

if(Keyboard.current.spaceKey.wasPressedThisFrame && isGrounded && active_saut){

	rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
	active_saut = false;
}
	if(rb.linearVelocity.y < 0 || Input.GetKeyUp(KeyCode.Space)){
		rb.gravityScale = 2;
	}
	
	if(isGrounded && rb.linearVelocity.y < 0)
	{
		rb.gravityScale = 1;
	}
}

		public void OnCollisionEnter2D(Collision2D collision){
			if(collision.gameObject.CompareTag("Sol")){
				active_saut = true;
			}
			
			if(collision.gameObject.CompareTag("Mur")){
				SceneManager.LoadScene("Scene next");
			}
			
		}
		
}