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
	public float vitesse = 2.0f;
	public float rotation = 5.0f;
	private Rigidbody2D rb;
	public float jumpForce = 10.0f;
	public LayerMask groundLayer;
	public Transform groundCheck;
	private bool isGrounded;
	public bool active_saut = false;
	public GameObject coeurs;
	public GameObject joueur;
	public GameObject plateforme;
	public GameObject coeur1;
	public GameObject coeur2;
	public GameObject coeur3;
	public GameObject bombe1;
	public GameObject bombe2;
	public GameObject bombe3;
	public Button buttonContinuer;
	public Button buttonRejouer;
	public Button buttonQuitter;
	public GameObject backgroundGame;
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
	
	if (Input.GetKeyDown(KeyCode.Escape)){
		Time.timeScale = 0f;
		if(coeur1 != null){
			coeur1.gameObject.SetActive(false);
		}
		if(coeur2 != null){
			coeur2.gameObject.SetActive(false);
		}
		if(coeur3 != null){
			coeur3.gameObject.SetActive(false);
		}
		if(bombe1 != null){
			bombe1.gameObject.SetActive(false);
		}
		if(bombe2 != null){
			bombe2.gameObject.SetActive(false);
		}
		if(bombe3 != null){
			bombe3.gameObject.SetActive(false);
		}
		if(coeurs != null){
			coeurs.gameObject.SetActive(false);
		}
		if(joueur != null){
			joueur.gameObject.SetActive(false);
		}
		if(plateforme != null){
			plateforme.gameObject.SetActive(false);
		}
		if(buttonContinuer != null){
			buttonContinuer.gameObject.SetActive(true);
		}
		if(buttonRejouer != null){
			buttonRejouer.gameObject.SetActive(true);
		}
		if(buttonQuitter != null){
			buttonQuitter.gameObject.SetActive(true);
		}
        if(backgroundGame != null){
			backgroundGame.gameObject.SetActive(true);
		}
		
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
		public void Rejouer()
	{
		SceneManager.LoadScene("Base Level");
	}
	
	public void Quitter()
	{
		SceneManager.LoadScene("QuitGame");
	}
}