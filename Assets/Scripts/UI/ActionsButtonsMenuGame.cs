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

		SceneManager.LoadScene("Level-1");

	}
	
	public void Options()
	{
		SceneManager.LoadScene("CommandesGame");
	}
	
	public void Quitter()
	{
		Application.Quit();
	}
}
