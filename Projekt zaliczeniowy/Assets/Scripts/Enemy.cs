using UnityEngine.SceneManagement;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            // game over 
            SceneManager.LoadScene(0);
        }    
    }
}
