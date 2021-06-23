using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public int Bullets;
    public GameObject BulletsPrefab;
    public Transform Spawn;
    public GameObject Flash;
    public Text BulletsCount;
    public AudioSource AudioShot;

    public float Delay;
    public float Period;

    public Vector3 StartPosition;
    public Vector3 AimPosition;

    private void Start()
    {
        BulletsCount.text = "Bullets: " + Bullets;

        StartPosition = transform.localPosition;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, AimPosition, Time.deltaTime * 8);
        }
        else
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, StartPosition, Time.deltaTime * 8);
        }

        Delay += Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            if (Bullets > 0)
            {
                if (Delay >= Period)
                {
                    Bullets -= 1;

                    GameObject newBullet = Instantiate(BulletsPrefab, Spawn.transform.position,
                        Spawn.transform.rotation);
                    newBullet.GetComponent<Rigidbody>().velocity = Spawn.transform.forward * 500;
                    AudioShot.pitch = Random.Range(0.8F, 1.2F);
                    AudioShot.Play();

                    Delay = 0;

                    Flash.SetActive(true);
                    Invoke(nameof(HideFlash), Period);
                }
            }
            else
            {
                //Debug.Log("Нет пуль!");
            }
        }
        SetCountText();
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Bullets = 30;
            //Debug.Log("R");
        }
    }

    private void HideFlash()
    {
        Flash.SetActive(false);
    }

    public void SetCountText()
    {
        BulletsCount.text = "Bullets: " + Bullets;
    }
}
