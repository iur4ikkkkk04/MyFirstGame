using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPart : MonoBehaviour
{
    public Rigidbody Rb;
    public Enemy ThisEnemy;

    // Start is called before the first frame update
    void Start()
    {
        Rb.isKinematic = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            ThisEnemy.TakeDamage();
        }
    }
}
