using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerBehaviour : MonoBehaviour
{
    public static GameManagerBehaviour instance;
    public int fireZoneDamage = -1;
    public int fallDamage = -1;

    const int MAX_LIFES = 5;
    const int BASE_LIFES = 3;
    public int lifes;
    
    private Vector2 startPosition;


      void Awake()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Debug.LogWarning("Two or more Gamemanager in the scene! Disabling new one", this);
            gameObject.SetActive(false);
        }
        lifes = BASE_LIFES;
    }
    void Start()
    {
    }

    // This method is use to store the start position of the player when the game starts, this position will be used to reposition the player when he has no more lifes
    public void OnStartGame(Vector2 position)
    {
        startPosition = position;
    }

    // This method is called when the player die
    public void OnPlayerDeath()
    {
        OnLifeChange(fallDamage);
    }

    // This method is called when the player takes damage from a fire zone
    public void OnFireZoneHit()
    {
        OnLifeChange(fireZoneDamage);
    }
    void OnLifeChange(int damage)
    {
        lifes = Mathf.Clamp(lifes+damage, 0, MAX_LIFES);
    }

    public void AddOneLife()
    {
        OnLifeChange(1);
    }

    // This method checks if the player has no more lifes and resets the player position to the start position and resets the player lifes to base value
    void GameOver()
    {
        if (lifes <= 0)
        {
            SceneManager.LoadScene("EndGame");
        }

    }
    void Update()
    {
        GameOver();
    }
}
