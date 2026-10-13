using UnityEngine;
using UnityEngine.UI;

public class HUDPower : MonoBehaviour
{
    public GameObject hudpower;

    void Start(){
        
    }
  
 

    public void UpdateActivePower(Power power)
    {
        switch(power)
        {
            case Power.Dash :
                hudpower.transform.GetChild(0).GetComponent<RawImage>().color = Color.red;
                hudpower.transform.GetChild(1).GetComponent<RawImage>().color = Color.white;
                break;
            case Power.FireArmor :
                hudpower.transform.GetChild(0).GetComponent<RawImage>().color = Color.white;
                hudpower.transform.GetChild(1).GetComponent<RawImage>().color = Color.red;
                break;
        }
       
    }

 void SetPowerActive()
    {
        
    }
}
