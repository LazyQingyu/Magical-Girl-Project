using Unity.VisualScripting;
using UnityEngine;

public class MovingPlateformDev : MonoBehaviour
{
    [Header("Plateform Movement")]
    [SerializeField] private float speed = 2f;
    [SerializeField] private float distance;
    [SerializeField] Transform PointA;
    [SerializeField] Transform PointB;
    [SerializeField] Transform currentPositionPlateform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentPositionPlateform = PointA;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, currentPositionPlateform.position);
        if (distance < 0.1f)
        {
            // Go to pointB
            if (currentPositionPlateform == PointA)
            {
                currentPositionPlateform = PointB;
            }
            else
            {
                currentPositionPlateform = PointA;
            }
        }
        else
        {
            // Go to pointA
            transform.position = Vector3.MoveTowards(transform.position, currentPositionPlateform.position, speed * Time.deltaTime);
        }
       
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}
