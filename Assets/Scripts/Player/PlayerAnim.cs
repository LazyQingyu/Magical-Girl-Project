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

    public void SetDashStatus(bool status)
    {
        dashStatus = status;
    }
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
    public IEnumerator HitFx()
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
