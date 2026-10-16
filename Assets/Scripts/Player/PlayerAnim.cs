using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    //[SerializeField] private Animator animator;
    //[SerializeField] private SpriteRenderer sprite_renderer;

    private PlayerController player_control;
    
    [Header("Fx")]
    //[SerializeField] private GameObject dashParticles;
    [SerializeField] private GameObject fireArmorParticles;    
    void Start()
    {
        player_control = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireArmorFx(bool active)
    {
        fireArmorParticles.SetActive(active);
    }
}
