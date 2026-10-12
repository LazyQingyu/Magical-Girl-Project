using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.InputSystem;

public class ActionsButtonsPauseGame : MonoBehaviour
{
    
	public Button buttonContinuer;
	public Button buttonRejouer;
	public Button buttonQuitter;
	
	
    void Start()
    {
		
        NewScriptableObjectScript.scores = PlayerPrefs.GetInt("Score", NewScriptableObjectScript.scores);
		
    }

    void Update()
    {
        
    }
			


	public void Continuer()
	{
		SceneManager.LoadScene("Game");
	}
	
	public void Rejouer()
	{
		NewScriptableObjectScript.scores = 0;
		PlayerPrefs.SetInt("Score", 0);
		PlayerPrefs.Save();
		SceneManager.LoadScene("Game");
	}
	
	public void Quitter()
	{
		if(NewScriptableObjectScript.scores > 0){
		NewScriptableObjectScript.scores = 0;
		PlayerPrefs.SetInt("Score", 0);
		PlayerPrefs.Save();
		Debug.Log("Score :  " + NewScriptableObjectScript.scores);
		}
		SceneManager.LoadScene("QuitGame");
	}
}
