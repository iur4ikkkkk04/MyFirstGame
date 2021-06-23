using Eccentric;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : SlainManager
{
    public GameObject Finish;
    public Text LifesCount;

    public PlayerMove PlayerMove;

    private void Start()
    {
        LifesCount.text ="Lifes: " + cfg.Health.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyFoot") && cfg.Health > 0)
        {
            TakeDamagePlayer();
        }
    }
    private void Update()
    {
        LifesCount.text = "Lifes: " + cfg.Health.ToString();
    }
    public void TakeDamagePlayer()
    {
        cfg.Health -= 1;
        if (cfg.Health <= 0)
        {
            DebugLoger s1 = DebugLoger.GetInstance();
            PlayerMove.enabled = false;
            Finish.SetActive(true);
            s1.Write("Игрок получил по шапке и умер");
        }
    }
}
