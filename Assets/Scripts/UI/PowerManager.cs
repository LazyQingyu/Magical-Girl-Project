using UnityEngine;

public class PowerManager : MonoBehaviour
{
    public GameObject PouvoirDashDown;
	public GameObject ArmureDeFeuDown;
	public GameObject PouvoirDashUp;
	public GameObject ArmureDeFeuUp;
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

				PouvoirDashDown.gameObject.SetActive(state);
				PouvoirDashUp.gameObject.SetActive(!state);
				ArmureDeFeuDown.gameObject.SetActive(!state);
				ArmureDeFeuUp.gameObject.SetActive(state);
				

			break;
			
			case Power.FireArmor:
			
			
				PouvoirDashDown.gameObject.SetActive(!state);
				PouvoirDashUp.gameObject.SetActive(state);
				ArmureDeFeuDown.gameObject.SetActive(state);
				ArmureDeFeuUp.gameObject.SetActive(!state);

			break;
			
			case Power.None:
			
				PouvoirDashDown.gameObject.SetActive(!state);
				PouvoirDashUp.gameObject.SetActive(state);
				ArmureDeFeuDown.gameObject.SetActive(!state);
				ArmureDeFeuUp.gameObject.SetActive(state);
				
			break;
		}

	}
}

