using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
    public GameObject key;
    public GameObject wall;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlatformGreen"))
        {
            key.SetActive(true);
            wall.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlatformGreen"))
        {
            key.SetActive(false);
            wall.SetActive(false);
        }
    }
}
