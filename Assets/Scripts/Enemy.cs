using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private GameObject Player;
    public NavMeshAgent Dest;
    public Animator EnemyAnimator;
    public BodyPart[] AllBodyParts;
    [Space]

    public float EnemySpeed;
    public int Health;
    public EnemyCreator EnemyCreator;

    private SlainManager _slainEnemy;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        _slainEnemy = FindObjectOfType<SlainManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Dest.SetDestination(Player.transform.position);

        if (Vector3.Distance(gameObject.transform.position, Player.transform.position) > 2.65F)
        {
            EnemyAnimator.SetBool("Attack", false);
            Dest.speed = EnemySpeed;
        }
        else
        {
            EnemyAnimator.SetBool("Attack", true);
            Dest.speed = 0;
        }
    }

    public void TakeDamage()
    {
        Health -= 1;

        EnemyAnimator.SetTrigger("Hit");

        if (Health == 0)
        {
            _slainEnemy.Slain();
        }

        if (Health <= 0)
        {
            Dest.enabled = false;
            EnemyAnimator.enabled = false;
            this.enabled = false;

            foreach (var item in AllBodyParts)
            {
                item.GetComponent<Rigidbody>().isKinematic = false;
                item.GetComponent<Rigidbody>().AddForce(0, 2000, 0);
                item.GetComponent<Rigidbody>().AddForce(-transform.forward * 500);
            }
            
            Destroy(gameObject, 4F);
        }
    }
}
