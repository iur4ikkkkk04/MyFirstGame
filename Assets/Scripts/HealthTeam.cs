using UnityEngine;

public class HealthTeam : MonoBehaviour
{
    public int Health = 2;
    public GameObject BangEffectPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyFoot"))
        {
            TakeDamageTeam();
        }
    }
    public void TakeDamageTeam()
    {
        Health -= 1;
        if (Health <= 0)
        {
            Instantiate(BangEffectPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
