using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PlayerBehaviour : MonoBehaviour
{
    private Vector2 startPosition;
    private Vector2 checkPoint;

    public VieJoueur hudLife;
    private bool isFireArmorActive;

    private PlayerAnim playerAnim;
    public PlayerController playerController;
    public UnityEvent TakeDamage;
    void Awake()
    {
        startPosition = transform.position;
        checkPoint = startPosition;
        playerAnim = GetComponent<PlayerAnim>();
    }

    void Start()
    {
        // Set the start position and checkpoint when the game starts in the GameManager
        GameManagerBehaviour.instance.OnStartGame(startPosition);
    }

    void Dead()
    {
        StartCoroutine(DeathSequence());
    }
    // This method is used to reposition the player when he dies, freeze the player input up to the end of the death animation, reposition the player to the last checkpoint and update the player life in the GameManager
    IEnumerator DeathSequence()
    {
        
        GameManagerBehaviour.instance.OnPlayerDeath();
        TakeDamage?.Invoke();
        playerController.FreezePlayerInput(true);
        RepositionPlayer(checkPoint);
        yield return playerAnim.DeathFx();
        playerController.FreezePlayerInput(false);
    }
    // This method update the player life in the GameManager when the player takes damage from a fire zone, if the player has fire armor active he will not take damage
    void DamageByFireZone()
    {
        if (!isFireArmorActive)
        {
            playerAnim.HitFx();
            GameManagerBehaviour.instance.OnFireZoneHit();
            TakeDamage?.Invoke();
        }
    }
    // This method is use to reposition the player to a new position, usually used when the player die and need to be repositioned to the last checkpoint or start position
    public void RepositionPlayer(Vector2 newPosition)
    {
        transform.position = newPosition;
    }
    // This method set the fire armor status to true or false, if true the player will not take damage from fire zones
    public void SetFireArmorStatus(bool status)
    {
        isFireArmorActive = status;
    }
    // Check collision with fire zones, checkpoints and death zones, if the player collide with a fire zone he will take damage, if he collide with a checkpoint the checkpoint position will be updated 
    // and if he collide with a death zone he will die
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Fire"))
        {
            DamageByFireZone();
        }

        if (collision.CompareTag("CheckPoint"))
        {
            checkPoint = collision.transform.position;
        }

        if(collision.CompareTag("DeathZone"))
        {
            Dead();
        }

        if (collision.CompareTag("Vie"))
        {
            hudLife.UpdateAtAddLife();
        }

    }
}
