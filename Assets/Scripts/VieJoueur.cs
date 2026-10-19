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
	public GameManagerBehaviour vie;
	int vies;

    void Start()
    {
		 vies = GameManagerBehaviour.instance.lifes;
		
    }

    void Update()
    {
        
    }
	
	public void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.CompareTag("Vie")){
			Destroy(collision.gameObject);
			if(vies > 0 && vies < 3){
				coeurs.transform.GetChild(vies).gameObject.SetActive(true);
				//vies += 1;
				//SaveLife.lifeJoueur += 1;
				//Debug.Log(SaveLife.lifeJoueur);
				UpdateLife(1);
			}
		}

		if(collision.gameObject.CompareTag("Bombe")){
				Destroy(collision.gameObject);
				vies -= 1;
				UpdateLife(vies);
				//SaveLife.lifeJoueur -= 1;
				//Debug.Log(SaveLife.lifeJoueur);
				coeurs.transform.GetChild(vies).gameObject.SetActive(false);
		}
		if(vies == 0){
				Destroy(gameObject);
				SceneManager.LoadScene("EndGame");
		}

	}
void UpdateLife(int life){
	GameManagerBehaviour.instance.OnLifeChange(life);
}

}
