using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSlain : SlainManager
{
    public Text SlainText;

    // Start is called before the first frame update
    void Start()
    {
        SlainText.text = "Slain: " + cfg.EnemySlain;
    }

    // Update is called once per frame
    void Update()
    {
        SlainText.text = "Slain: " + cfg.EnemySlain;
    }
}
