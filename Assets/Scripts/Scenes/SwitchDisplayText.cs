using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchDisplayText : MonoBehaviour {

    public string LEVEL_TEXT = "LEVEL";
    public string LEVEL_NUMBER = "1";

    public float SWITCH_INTERVAL = 1.5f;
    private float countTime = 0;
    private Text mText;

    void Awake()
    {
        mText = GetComponent<Text>();
    }

    void Update()
    {
        if (countTime < SWITCH_INTERVAL)
        {
            countTime += Time.deltaTime;

        }
        else
        {
            countTime = 0;
            mText.text = (mText.text == LEVEL_TEXT) ? LEVEL_NUMBER : LEVEL_TEXT;
        }
    }
}
