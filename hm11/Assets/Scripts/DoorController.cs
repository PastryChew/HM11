using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorController : MonoBehaviour
{

    public GameObject key;
    public GameObject Door;
    public Text HintText;
    public bool haveKey = false;
    private bool doorisnear = false;
    public GameObject effect;

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && doorisnear)
        {
            
            Door.SetActive(false);
            HintText.gameObject.SetActive(false);
        }
    }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Key"))
            {
                effect.SetActive(true);
                key.SetActive(false);
                haveKey = true;
            }
            if (other.CompareTag("Door") && haveKey)
            {
                HintText.gameObject.SetActive(true);
                doorisnear = true;
               

            }
        }
        private void OnTriggerExit(Collider other)
        {
            HintText.gameObject.SetActive(false);
        }

}
