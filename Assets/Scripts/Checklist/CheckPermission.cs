using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPermission 
{

    private IPermission _permission;

    public CheckPermission(IPermission permission)
    {
        _permission = permission;
    }

    public void DoCheck(CheckListElement checkListElement)
    {
        _permission.CheckPermissions(checkListElement);
    }
}
