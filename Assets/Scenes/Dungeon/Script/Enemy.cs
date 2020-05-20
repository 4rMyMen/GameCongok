using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    PlayerManager playerManager;
    CharacterStat myStats;
    // Start is called before the first frame update
    void Start()
    {
        playerManager = PlayerManager.instance;
        myStats = GetComponent<CharacterStat>();
    }
}
