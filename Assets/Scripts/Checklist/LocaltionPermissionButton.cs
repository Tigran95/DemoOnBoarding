using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LocaltionPermissionButton : Selectable
{
    [SerializeField] private CheckListElement checkListElement;
    public override void OnPointerUp(PointerEventData eventData)
    {
        new CheckPermission(new CheckLoactionPermissions()).DoCheck(checkListElement);
    }
}
