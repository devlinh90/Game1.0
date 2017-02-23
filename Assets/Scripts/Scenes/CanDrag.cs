using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CanDrag : EventTrigger
{
    public override void OnDrag(PointerEventData eventData)
    {
        // Change Canvas render mode to screen space - Camera for easy change postion
        transform.position = Input.mousePosition;
    }

}
