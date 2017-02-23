using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Level4BarController : EventTrigger {

    private Image image;
    private Color originColor;
    void Awake()
    {
        image = GetComponent<Image>();
        originColor = image.color;
    }
    public override void OnPointerEnter(PointerEventData data)
    {
        image.color = Color.clear;
    }

    public override void OnPointerExit(PointerEventData data)
    {
        image.color = originColor;
    }

    
}
