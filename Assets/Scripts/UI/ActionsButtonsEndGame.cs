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
		SceneManager.LoadScene("Level-1");
	}
	
	public void Quitter()
	{
		SceneManager.LoadScene("QuitGame");
	}
}
