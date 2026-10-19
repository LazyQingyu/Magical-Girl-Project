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
		for(int i = 0; i < vies; i++)
		{
			coeurs.transform.GetChild(vies-i).gameObject.SetActive(false);
		}
	}

	public void UpdateAtAddLife()
	{
		GameManagerBehaviour.instance.AddOneLife();
		vies = GameManagerBehaviour.instance.lifes;
		for(int i = 0; i < vies; i++)
		{
			coeurs.transform.GetChild(i).gameObject.SetActive(true);
		}
	}
	
}
