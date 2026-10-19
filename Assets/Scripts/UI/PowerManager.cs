using UnityEngine;
using TMPro;

public class PowerManager : MonoBehaviour
{
    public GameObject pouvoirDashDown;
	public GameObject armureDeFeuDown;
	public GameObject pouvoirDashUp;
	public GameObject armureDeFeuUp;
	public TextMeshProUGUI textDash;
	public TextMeshProUGUI textArmor;
	private bool state = false;
	
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void AssignPower(Power sort){

		
		switch(sort){
			
			case Power.Dash:

				pouvoirDashDown.gameObject.SetActive(state);
				pouvoirDashUp.gameObject.SetActive(!state);
				armureDeFeuDown.gameObject.SetActive(!state);
				armureDeFeuUp.gameObject.SetActive(state);
				textDash.text = "R";		
				textArmor.text = "E";
			break;
			
			case Power.FireArmor:
			
			
				pouvoirDashDown.gameObject.SetActive(!state);
				pouvoirDashUp.gameObject.SetActive(state);
				armureDeFeuDown.gameObject.SetActive(state);
				armureDeFeuUp.gameObject.SetActive(!state);
				textDash.text = "A";
				textArmor.text = "R";

			break;
			
			case Power.None:
			
				pouvoirDashDown.gameObject.SetActive(!state);
				pouvoirDashUp.gameObject.SetActive(state);
				armureDeFeuDown.gameObject.SetActive(!state);
				armureDeFeuUp.gameObject.SetActive(state);
				textDash.text = "A";
				textArmor.text = "E";
			break;
		}

	}
}

