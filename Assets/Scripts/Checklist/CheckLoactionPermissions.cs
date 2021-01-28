using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLoactionPermissions : IPermission
{
    public void CheckPermissions(CheckListElement checkListElement)
    {
        Debug.Log("EnableLocation");
        checkListElement.DoCheck();
    }
}
