using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InPauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public bool clicked;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        pauseMenuUI.SetActive(clicked);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
