using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIAppear : MonoBehaviour
{
    public GameObject customImage;
    public int sceneIndex;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            customImage.SetActive(true);
        }    
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(sceneIndex);
            }
        }    
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            customImage.SetActive(false);
        }
    }
}
