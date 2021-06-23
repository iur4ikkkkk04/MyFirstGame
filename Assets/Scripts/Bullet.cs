using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject HitEffect;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(HitEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
