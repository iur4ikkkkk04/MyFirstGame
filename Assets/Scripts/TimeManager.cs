using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Time.timeScale = 0.2F;
            Time.fixedDeltaTime = 0.02F * 0.2F;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Time.timeScale = 1F;
            Time.fixedDeltaTime = 0.02F;
        }
    }
}
