using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.InputSystem;

public class ActionsButtonsPauseGame : MonoBehaviour
{
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
		
    }

    void Update()
    {
        
    }
			


	public void Continuer()
	{
		Time.timeScale = 1f;
		//SceneManager.LoadScene("Base Level");
		/*
		coeurs.gameObject.SetActive(true);
		joueur.gameObject.SetActive(true);
		plateforme.gameObject.SetActive(true);
		coeur1.gameObject.SetActive(true);
		coeur2.gameObject.SetActive(true);
		coeur3.gameObject.SetActive(true);
		bombe1.gameObject.SetActive(true);
		bombe2.gameObject.SetActive(true);
		bombe3.gameObject.SetActive(true);
		buttonContinuer.gameObject.SetActive(false);
		buttonRejouer.gameObject.SetActive(false);
		buttonQuitter.gameObject.SetActive(false);
		backgroundGame.gameObject.SetActive(false);
		*/
		if(coeur1 != null){
			coeur1.gameObject.SetActive(true);
		}
		if(coeur2 != null){
			coeur2.gameObject.SetActive(true);
		}
		if(coeur3 != null){
			coeur3.gameObject.SetActive(true);
		}
		if(bombe1 != null){
			bombe1.gameObject.SetActive(true);
		}
		if(bombe2 != null){
			bombe2.gameObject.SetActive(true);
		}
		if(bombe3 != null){
			bombe3.gameObject.SetActive(true);
		}
		if(coeurs != null){
			coeurs.gameObject.SetActive(true);
		}
		if(joueur != null){
			joueur.gameObject.SetActive(true);
		}
		if(plateforme != null){
			plateforme.gameObject.SetActive(true);
		}
		if(buttonContinuer != null){
			buttonContinuer.gameObject.SetActive(false);
		}
		if(buttonRejouer != null){
			buttonRejouer.gameObject.SetActive(false);
		}
		if(buttonQuitter != null){
			buttonQuitter.gameObject.SetActive(false);
		}
        if(backgroundGame != null){
			backgroundGame.gameObject.SetActive(false);
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
