using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.InputSystem;

public class ScoreMaxTexte : MonoBehaviour
{
	public int scoreMax;
	public TextMeshProUGUI maxScoreText;
	public NewScriptableObjectScript scores;
	
    void Start()
    {
        scoreMax = PlayerPrefs.GetInt("Score Max", scoreMax);
    }

    void Update()
    {
    if (NewScriptableObjectScript.scores > scoreMax)
        {
            scoreMax = NewScriptableObjectScript.scores;
            PlayerPrefs.SetInt("Score Max", scoreMax);			
            maxScoreText.text = "Meilleur score : " + scoreMax;
        } else {
		}
    }
}
