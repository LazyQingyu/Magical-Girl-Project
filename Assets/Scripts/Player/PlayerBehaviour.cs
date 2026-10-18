using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PlayerBehaviour : MonoBehaviour
{
    private Vector2 startPosition;
    private Vector2 checkPoint;

    private bool isFireArmorActive;

    private PlayerAnim playerAnim;
    public PlayerController playerController;
    public UnityEvent HitByFire;
    public UnityEvent DeathOccurs;

    void Awake()
    {
        startPosition = transform.position;
        checkPoint = startPosition;
        playerAnim = GetComponent<PlayerAnim>();
    }

    void Dead()
    {
        StartCoroutine(DeathSequence());
    }
    IEnumerator DeathSequence()
    {
        DeathOccurs?.Invoke();
        playerController.FreezePlayerInput(true);
        RepositionPlayer(checkPoint);
        yield return StartCoroutine(playerAnim.HitFx());
        playerController.FreezePlayerInput(false);
    }
    void DamageByFireZone()
    {
        if (!isFireArmorActive)
        {
            HitByFire?.Invoke();
        }
    }
    void RepositionPlayer(Vector2 newPosition)
    {
        transform.position = newPosition;
    }
    public void SetFireArmorStatus(bool status)
    {
        isFireArmorActive = status;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Fire"))
        {
            DamageByFireZone();
        }

        if (collision.CompareTag("CheckPoint"))
        {
            Debug.Log("Checkpoint reached");
            checkPoint = collision.transform.position;
        }

        if(collision.CompareTag("DeathZone"))
        {
            Dead();
        }

    }
}
