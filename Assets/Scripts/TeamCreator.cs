using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamCreator : MonoBehaviour
{
    public GameObject TeamPrefab;
    public float CreationPeriod;
    public float Timer;

    public float randomOffsetValue;

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= CreationPeriod)
        {
            Vector3 randomOffset = new Vector3(Random.Range(-randomOffsetValue, randomOffsetValue), 0,
                Random.Range(-randomOffsetValue, randomOffsetValue));

            //Instantiate(BarrelPrefab, new Vector3(Random.Range(15, 26), 0,
            //    Random.Range(5, -8)), transform.rotation);
            Instantiate(TeamPrefab, transform.position + randomOffset, transform.rotation);
            Timer = 0;
        }
    }
}
