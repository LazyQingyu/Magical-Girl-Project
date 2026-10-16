using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneChanger : MonoBehaviour
{
    public int indexScene;

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadSceneAsync(indexScene);
        }
    }
}