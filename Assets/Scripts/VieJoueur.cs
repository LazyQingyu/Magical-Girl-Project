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
		Debug.Log(vies);
    }

	public void UpdateHUDLife()
	{	
		vies = GameManagerBehaviour.instance.lifes;
		Debug.Log("vies in hud update : "+vies);
		if(vies > 0 && vies < 3){
			coeurs.transform.GetChild(vies).gameObject.SetActive(false);
		}
	}
	
}
