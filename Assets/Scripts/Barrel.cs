using UnityEngine;

public class Barrel : MonoBehaviour
{
    public GameObject BangEffectPrefab;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Collider[] AllColl = Physics.OverlapSphere(transform.position, 13);
            foreach (var item in AllColl)
            {
                if (item.attachedRigidbody)
                {
                    if (item.GetComponent<BodyPart>())
                    {
                        item.GetComponent<BodyPart>().ThisEnemy.TakeDamage();
                    }
                    if (item.attachedRigidbody.GetComponent<HealthPlayer>())
                    {
                        item.attachedRigidbody.GetComponent<HealthPlayer>().TakeDamagePlayer();
                    }
                    if (item.attachedRigidbody.GetComponent<HealthTeam>())
                    {
                        item.attachedRigidbody.GetComponent<HealthTeam>().TakeDamageTeam();
                    }
                    // Притягивает
                    //Vector3 dir = (transform.position - item.transform.position).normalized;
                    // Отталкивает
                    Vector3 dir = (item.transform.position - transform.position).normalized;

                    item.attachedRigidbody.AddForce(dir * 2000);
                }
            }

            Instantiate(BangEffectPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
