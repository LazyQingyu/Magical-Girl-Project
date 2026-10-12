using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.InputSystem;

public class ScoreTexte : MonoBehaviour
{
	public TextMeshProUGUI scoreText;
	public NewScriptableObjectScript scores;
	
    void Start()
    {
			NewScriptableObjectScript.scores = PlayerPrefs.GetInt("Score", NewScriptableObjectScript.scores);
    }

    void Update()
    {
		scoreText.text = "Votre score : "+(NewScriptableObjectScript.scores).ToString();	
    }
}
