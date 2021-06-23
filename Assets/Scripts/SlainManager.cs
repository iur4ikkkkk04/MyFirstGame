using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlainManager : MonoBehaviour
{
    public bool ForNewEnemy;
    public PlayerConfig cfg = new PlayerConfig
    {
        Health = 5,
        EnemySlain = 0
    };

    public void Slain()
    {
        cfg.EnemySlain++;
        ForNewEnemy = true;
    }
}
