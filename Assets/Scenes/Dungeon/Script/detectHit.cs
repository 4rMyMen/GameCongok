using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class detectHit : MonoBehaviour
{
    Animator anim;
    public Slider healthBar;
    public string opponent;
    public GameObject diedNotif;

    void OnTriggerEnter(Collider other)
    {
        // Debug.Log(other.gameObject.name);
        if (other.gameObject.tag != opponent) return;
        healthBar.value -= 20;
        if(healthBar.value <= 0)
        {
            anim.SetBool("isDead", true);
            if (gameObject.tag == "Player")
            {
                diedNotif.SetActive(true);
                Invoke("Died", 4f);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Died()
    {
        Cursor.lockState = CursorLockMode.None;
        diedNotif.SetActive(false);
        SceneManager.LoadScene(2);
    }
}
