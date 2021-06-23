using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DeastroyTeam : MonoBehaviour
{
    public float Timer;
    public float CreationPeriod;

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer > CreationPeriod)
        {
            Destroy(gameObject);
        }
    }
}
