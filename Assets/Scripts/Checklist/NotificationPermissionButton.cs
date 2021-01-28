﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NotificationPermissionButton : Selectable
{
    [SerializeField] private CheckListElement checkListElement;
    public override void OnPointerUp(PointerEventData eventData)
    {
        new CheckPermission(new CheckNotificationsPermissions()).DoCheck(checkListElement);
    }
}
