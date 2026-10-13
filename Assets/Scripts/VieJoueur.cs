using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class VieJoueur : MonoBehaviour
{

	public GameObject coeurs;
	public SaveLife vie;
	//public int vieJoueur = 3;
	
    void Start()
    {
		//SaveLife.lifeJoueur = vieJoueur;
    }

    void Update()
    {
        
    }
	
	public void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.CompareTag("Vie")){
			Destroy(collision.gameObject);
			if(SaveLife.lifeJoueur > 0 && SaveLife.lifeJoueur < 3){
				coeurs.transform.GetChild(SaveLife.lifeJoueur).gameObject.SetActive(true);
				SaveLife.lifeJoueur += 1;
				//SaveLife.lifeJoueur += 1;
				//Debug.Log(SaveLife.lifeJoueur);
			}
		}

		if(collision.gameObject.CompareTag("Bombe")){
				Destroy(collision.gameObject);
				SaveLife.lifeJoueur -= 1;
				//SaveLife.lifeJoueur -= 1;
				//Debug.Log(SaveLife.lifeJoueur);
				coeurs.transform.GetChild(SaveLife.lifeJoueur).gameObject.SetActive(false);
		}
			if(SaveLife.lifeJoueur == 0){
				Destroy(gameObject);
				SceneManager.LoadScene(SceneManager.GetActiveScene().name);
				SaveLife.lifeJoueur = 3;
			}

	}

	
}
