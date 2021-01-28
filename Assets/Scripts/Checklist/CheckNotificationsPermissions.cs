using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckNotificationsPermissions : IPermission
{
    public void CheckPermissions(CheckListElement checkListElement)
    {
        Debug.Log("EnableNotifications");
        checkListElement.DoCheck();
    }
}
