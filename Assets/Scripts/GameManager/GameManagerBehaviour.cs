using UnityEngine;

public class GameManagerBehaviour : MonoBehaviour
{
    public static GameManagerBehaviour instance;
    public int fireZoneDamage = -1;

    const int MAX_LIFES = 5;
    private int lifes;
    
    private Vector2 startPosition;
    private Vector2 checkPoint;

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
        lifes = 3;
    }
    void Start()
    {
    }


    public void OnStartGame(Vector2 position)
    {
        startPosition = position;
        checkPoint = startPosition;
    }

    public void OnCheckPointReached(Vector2 position)
    {
        checkPoint = position;
    }

    public void OnPlayerDeath()
    {
        OnLifeChange(-1);
    }
    public void OnFireZoneHit()
    {
        OnLifeChange(fireZoneDamage);
    }
    void OnLifeChange(int damage)
    {
        lifes = Mathf.Clamp(lifes+damage, 0, MAX_LIFES);
    }

    void GameOver()
    {
        if (lifes <= 0)
        {
            GetComponent<PlayerBehaviour>().RepositionPlayer(startPosition);
        }
        lifes = 3;
    }
    void Update()
    {
        
    }
}
