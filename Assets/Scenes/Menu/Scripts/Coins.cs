using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{

    GameObject currencyUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currencyUI = GameObject.Find("GameStatus");
        if(currencyUI == null)
        {
            Debug.LogError("Error");
            this.enabled = false;
            return;
        }
        GameStatus go = currencyUI.GetComponent<GameStatus>();
        GetComponent<Text>().text = go.gold.ToString();
        
        if(go.gold < 0)
        {
            go.gold = 0;
        }
    }
}
