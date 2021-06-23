using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScooterCreator : MonoBehaviour
{
    public GameObject ScooterPrefab;

    public float randomOffsetValue;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 randomOffset = new Vector3(Random.Range(-randomOffsetValue, randomOffsetValue), 0,
            Random.Range(-randomOffsetValue, randomOffsetValue));

        Instantiate(ScooterPrefab, transform.position + randomOffset, transform.rotation);
    }
}
