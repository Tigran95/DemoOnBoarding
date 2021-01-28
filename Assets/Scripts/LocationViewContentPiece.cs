using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class LocationViewContentPiece : ViewContentPiecesBase
{
    public override void DoMove()
    {
        TweensManager.Instance.DoMoveViewContent().OnComplete(() =>
        {
            PhoneTweensManager.Instance.DoFirstTween();
        });
    }
}
