using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.InputSystem;

public class ActionsButtonsEndGame : MonoBehaviour
{
    
	public Button buttonRejouer;
	public Button buttonQuitter;
	
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
	
	public void Rejouer()
	{
		SceneManager.LoadScene("Game");
		NewScriptableObjectScript.scores = 0;
		PlayerPrefs.SetInt("Score", 0);
		PlayerPrefs.Save();
		
	}
	
	public void Quitter()
	{
		//PlayerPrefs.DeleteKey("Score Max");
		if(NewScriptableObjectScript.scores > 0){
		NewScriptableObjectScript.scores = 0;
		PlayerPrefs.SetInt("Score", 0);
		PlayerPrefs.Save();
		Debug.Log("Score :  " + NewScriptableObjectScript.scores);
		}
		SceneManager.LoadScene("QuitGame");
	}
}
