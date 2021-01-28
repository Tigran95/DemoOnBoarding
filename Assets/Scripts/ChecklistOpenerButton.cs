using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ChecklistOpenerButton : Selectable
{
    public override void OnPointerUp(PointerEventData eventData)
    {
        enabled = false;
        TweensManager.Instance.DoMoveCheckList();
    }
}
