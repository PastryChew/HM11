using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FinishTrigger : MonoBehaviour
{
    

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
            
            
        }
        if (other.CompareTag("DeathTrigger"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
