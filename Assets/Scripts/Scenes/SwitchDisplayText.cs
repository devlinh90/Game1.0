using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchDisplayText : MonoBehaviour {

    public float rateTime = 1.5f;
    private float countTime = 0;
    public string text1 = "LEVEL";
    public string text2 = "1";


    private Text mText;

    void Awake()
    {
        mText = GetComponent<Text>();
    }

    void Update()
    {
        if (countTime < rateTime)
        {
            countTime += Time.deltaTime;

        }
        else
        {
            countTime = 0;
            if (mText.text == text1)
            {
                mText.text = text2;
            }
            else
            {
                mText.text = text1;
            }
        }
    }
}
