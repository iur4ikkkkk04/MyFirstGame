using UnityEngine;
using UnityEngine.UI;

public class EnemyCreator : MonoBehaviour
{
    public GameObject EnemyPrefab;
    private SlainManager _enemySc;
    public float CreationPeriod;
    public float Timer;

    public float randomOffsetValue;
    [Space]
    public int NumberOfEnemy = 0;
    public int MaxEnemy;

    private void Start()
    {
        _enemySc = FindObjectOfType<SlainManager>();
    }

    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= CreationPeriod)
        {
            //Instantiate(EnemyPrefab, new Vector3(Random.Range(15, 26), 0,
            //    Random.Range(5, -8)), transform.rotation);
            
            Vector3 randomOffset = new Vector3(Random.Range(-randomOffsetValue, randomOffsetValue), 0,
                Random.Range(-randomOffsetValue, randomOffsetValue));

            if (NumberOfEnemy < MaxEnemy)
            {
                Instantiate(EnemyPrefab, transform.position + randomOffset, transform.rotation);
                Timer = 0;
                NumberOfEnemy++;
            }

            if (_enemySc.cfg.EnemySlain != 0 & _enemySc.ForNewEnemy)
            {
                OneMoreEnemyAvailable();
            }
        }
    }
    public void OneMoreEnemyAvailable()
    {
        if (_enemySc.cfg.EnemySlain > NumberOfEnemy)
        {
            NumberOfEnemy = 0;
        }
        else
        {
            NumberOfEnemy -= _enemySc.cfg.EnemySlain;
        }
        _enemySc.ForNewEnemy = false;
    }
}
