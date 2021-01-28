using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCameraPermissions : IPermission
{
    public void CheckPermissions(CheckListElement checkListElement)
    {
        Debug.Log("EnableCamera");
        checkListElement.DoCheck();
    }
}
