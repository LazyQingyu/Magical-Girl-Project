using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HUDPower : MonoBehaviour
{
    public GameObject hudpower;
  
 

    public void UpdateActivePower(Power power)
    {
        hudpower.transform.GetChild(0);
    } 
}
