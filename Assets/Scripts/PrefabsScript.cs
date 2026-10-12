using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.InputSystem;

public class PrefabsScript : MonoBehaviour
{
    public float delaystart = 1.0f;
	public float interval = 2.0f;
	private float valuePositionX = 835.0f;
	private float valuePositionY = 435.0f;
	public ActionsButtonsGame modifyInvoke;
	public GameObject[] objets;
	
    void Start()
    {
		InvokeRepeating("Instanciations", delaystart, interval);
    }

    void Update()
    {
		if(modifyInvoke.serpent == null){
			CancelInvoke("Instanciations");
			foreach (GameObject obj in objets)
			{

			if (obj != null)
				{
					obj.SetActive(false);
				}
			}
			GameObject[] ObjetsDestroy = GameObject.FindGameObjectsWithTag("AllItems");

			foreach (GameObject obj in ObjetsDestroy)
			{
				Destroy(obj);	
			}
		}
		
    }
	private void Instanciations(){
		int chanceObjet = Random.Range(0, 66);
		int objetsIndex = Random.Range(0, objets.Length);
		Vector3 positionObjets = new Vector3(Random.Range(-valuePositionX, valuePositionX),Random.Range(-valuePositionY, valuePositionY-100.0f), 0);
		  switch(chanceObjet){

		  case 0:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;	
		  case 1:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 2:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 3:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 4:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 5:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 6:
			Instantiate(objets[5], positionObjets, objets[5].transform.rotation);
			break;
		  case 7:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 8:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;	
		  case 9:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 10:
			Instantiate(objets[2], positionObjets, objets[2].transform.rotation);
			break;
		  case 11:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 12:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 13:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 14:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 15:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 16:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;	
		  case 17:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 18:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 19:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 20:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 21:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 22:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 23:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 24:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;	
		  case 25:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 26:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 27:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 28:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 29:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 30:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 31:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 32:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 33:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;	
		  case 34:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 35:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 36:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 37:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 38:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 39:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 40:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 41:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;	
		  case 42:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 43:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 44:
			Instantiate(objets[3], positionObjets, objets[3].transform.rotation);
			break;
		  case 45:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 46:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 47:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 48:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 49:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;	
		  case 50:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 51:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 52:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 53:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 54:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 55:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 56:
			Instantiate(objets[3], positionObjets, objets[3].transform.rotation);
			break;
		  case 57:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;	
		  case 58:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 59:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 60:
			Instantiate(objets[4], positionObjets, objets[4].transform.rotation);
			break;
		  case 61:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 62:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 63:
			Instantiate(objets[1], positionObjets, objets[1].transform.rotation);
			break;
		  case 64:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
		  case 65:
			Instantiate(objets[0], positionObjets, objets[0].transform.rotation);
			break;
				} 

	}
}
	
	
	
	
	
	
	