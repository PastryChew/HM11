using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FinishTrigger : MonoBehaviour
{

    public GameObject deathEffects;
    public GameObject GameOverScreen;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (other.CompareTag("DeathTrigger"))
        {
            this.gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            deathEffects.SetActive(true);
            StartCoroutine(timer());
            
        }
        if (other.CompareTag("GameOver"))
        {
            GameOverScreen.SetActive(true);

        }
    }
    private IEnumerator timer()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
