using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public string goalName;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManagerBehaviour.instance.GoalReached(goalName);
        }
    }
}
