using System.Collections;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    
    private SpriteRenderer spriteRenderer;
    [SerializeField] private Animator playerAnimator;

    [Header("Fx")]
    [SerializeField] private GameObject fireArmorParticles;  

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void DashFx()
    {
        Debug.Log("Dash Fx");
    }

    public IEnumerator DeathFx()
    {
        playerAnimator.SetTrigger("isRespawn");
        for(int i = 0; i < 4; i++)
        {
            spriteRenderer.color = new Color(1, 1, 1, 0);
            yield return new WaitForSeconds(0.2f);
            spriteRenderer.color = new Color(1, 1, 1, 1);
            yield return new WaitForSeconds(0.2f);
        }
    }
    public void FireArmorFx(bool active)
    {
        fireArmorParticles.SetActive(active);
    }
}
