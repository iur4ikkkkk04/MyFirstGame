using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

public class Escape : MonoBehaviour
{
    public GameObject WinImg;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            WinImg.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
