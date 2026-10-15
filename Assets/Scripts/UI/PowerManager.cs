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

				PouvoirDashDown.gameObject.SetActive(state);//PowerDashDown Activer/Désactiver Désactiver
				PouvoirDashUp.gameObject.SetActive(!state);//ArmureDeFeuDown Activer/Désactiver Activer
				ArmureDeFeuDown.gameObject.SetActive(!state);//PowerDashUp Activer/Désactiver Activer
				ArmureDeFeuUp.gameObject.SetActive(state);//ArmureDeFeuUp Activer/Désactiver Désactiver
				

			break;
			
			case Power.FireArmor:
			
			
				PouvoirDashDown.gameObject.SetActive(!state);//PowerDashDown Activer/Désactiver Activer
				PouvoirDashUp.gameObject.SetActive(state);//ArmureDeFeuDown Activer/Désactiver Désactiver
				ArmureDeFeuDown.gameObject.SetActive(state);//PowerDashUp Activer/Désactiver Désactiver
				ArmureDeFeuUp.gameObject.SetActive(!state);//ArmureDeFeuUp Activer/Désactiver Activer

			break;
			/*
			case Power.None:
			
				PouvoirDashDown.gameObject.SetActive(state);//PowerDashDown Activer/Désactiver Désactiver
				PouvoirDashUp.gameObject.SetActive(state);//ArmureDeFeuDown Activer/Désactiver Activer
				ArmureDeFeuDown.gameObject.SetActive(state);//PowerDashUp Activer/Désactiver Désactiver
				ArmureDeFeuUp.gameObject.SetActive(state);//ArmureDeFeuUp Activer/Désactiver Activer
				*/
		}

	}
}

/*
		switch(chanceObjet){

		  case 0:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;	
		  case 1:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		}
*/


/*
				PouvoirDashDown.gameObject.SetActive(state);//PowerDashDown Activer/Désactiver Désactiver
				PouvoirDashUp.gameObject.SetActive(!state);//ArmureDeFeuDown Activer/Désactiver Activer
				ArmureDeFeuDown.gameObject.SetActive(!state);//PowerDashUp Activer/Désactiver Activer
				ArmureDeFeuUp.gameObject.SetActive(state);//ArmureDeFeuUp Activer/Désactiver Désactiver
				
				PouvoirDashDown.gameObject.SetActive(!state);//PowerDashDown Activer/Désactiver Activer
				PouvoirDashUp.gameObject.SetActive(state);//ArmureDeFeuDown Activer/Désactiver Désactiver
				ArmureDeFeuDown.gameObject.SetActive(state);//PowerDashUp Activer/Désactiver Désactiver
				ArmureDeFeuUp.gameObject.SetActive(!state);//ArmureDeFeuUp Activer/Désactiver Activer
*/
