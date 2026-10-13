using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.InputSystem;

public class ActionsButtonsMenuGame : MonoBehaviour
{
    
	public Button buttonJouer;
	public Button buttonOptions;
	public Button buttonQuitter;
	
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
	
	public void Jouer()
	{
		NewScriptableObjectScript.scores = 0;
		PlayerPrefs.SetInt("Score", 0);
		PlayerPrefs.Save();
		SceneManager.LoadScene("Game");

	}
	
	public void Options()
	{
		SceneManager.LoadScene("CommandesGame");
	}
	
	public void Quitter()
	{
		SceneManager.LoadScene("QuitGame");
	}
}
