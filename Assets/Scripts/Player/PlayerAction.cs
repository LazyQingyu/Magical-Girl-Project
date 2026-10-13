using UnityEngine;
using UnityEngine.Events;

public class PlayerAction : MonoBehaviour
{
    public UnityEvent <Power> ActivePower;


    void Update()
    {
        SelectActivePower();
    }

    void SelectActivePower()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ActivePower?.Invoke(Power.Dash);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ActivePower?.Invoke(Power.FireArmor);
        }
    }

}
