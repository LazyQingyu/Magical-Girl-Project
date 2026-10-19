using System.Collections;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    
    private SpriteRenderer spriteRenderer;
    public float afterImageLifeTime = 0.05f;
    public float afterImageSpawnRate = 0.1f;
    private bool dashStatus = false;
    [SerializeField] private Gradient afterImageGradient;
    [SerializeField] private Animator playerAnimator;

    [Header("Fx")]
    [SerializeField] private GameObject fireArmorParticles;
    [SerializeField] private GameObject dashParticles;

    [Header("Materials")]
    [SerializeField] private Material afterImageMaterial;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // This method is called when the unity event is triggered when the player start dashing and will update the dashStatus with the current status of the player dashing
    public void SetDashStatus(bool status)
    {
        dashStatus = status;
    }

    //This method is called when the player is dashing, it will create an after image effect and set the dash particles active, when the player stop dashing it will stop creating after images and deactivate the dash particles
    public IEnumerator AfterImageFx()
    {
        dashParticles.SetActive(true);
        while (dashStatus)
        {
            AfterImageTrail();
            yield return new WaitForSeconds(afterImageSpawnRate);
        }
        dashParticles.SetActive(false);
    }
    // Creates an after image effect by instantiating a new GameObject with the same sprite as the player and applying a material to it, then lerping the color of the after image over time to create a fading effect
    void AfterImageTrail()
    {
        GameObject afterImage = new GameObject("AfterImage");
        afterImage.transform.position = transform.position;
        SpriteRenderer afterImageRenderer = afterImage.AddComponent<SpriteRenderer>();
        afterImageRenderer.sprite = spriteRenderer.sprite;
        afterImageRenderer.transform.localScale = spriteRenderer.transform.localScale;
        afterImageRenderer.material = afterImageMaterial;
        StartCoroutine(LerpColor(afterImageRenderer));
    }

    // Lerp the color of the after image over time to create a fading effect, then destroy the after image GameObject after a short delay
    IEnumerator LerpColor(SpriteRenderer spriteRenderer)
    {
        float timer = 0f;
        while (timer < afterImageLifeTime)
        {
            timer += Time.deltaTime;
            spriteRenderer.color = afterImageGradient.Evaluate(timer / afterImageLifeTime);
            yield return null;
        }
        spriteRenderer.color = afterImageGradient.Evaluate(1f);
        Destroy(spriteRenderer.gameObject,0.3f);
    }

    public Coroutine DeathFx()
    {
        playerAnimator.SetTrigger("isRespawn");
        return StartCoroutine(HitAnim());

    }
    public void HitFx()
    {
        StartCoroutine(HitAnim());
    }
    // Fx when the player get hit or respawn, the player will flash for a short period of time to indicate that he is invulnerable
    IEnumerator HitAnim()
    {
        for(int i = 0; i < 4; i++)
        {
            spriteRenderer.color = new Color(1, 1, 1, 0);
            yield return new WaitForSeconds(0.2f);
            spriteRenderer.color = new Color(1, 1, 1, 1);
            yield return new WaitForSeconds(0.2f);
        }
    }

    // Active or deactivate the fire armor particles when the player get the fire armor power up or when the fire armor power up is over
    public void FireArmorFx(bool active)
    {
        fireArmorParticles.SetActive(active);
    }
}
