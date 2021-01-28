using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CameraBottomContentPiece : BottomContentPiecesBase
{
    public override void DoMove()
    {
        PhoneTweensManager.Instance.DoLastTween().OnComplete(() =>
        {
            TweensManager.Instance.DoMoveBottomContent().OnComplete(() =>
            {
                PhoneTweensManager.Instance.DoBookModelTween();
            });
        });
    }
}
