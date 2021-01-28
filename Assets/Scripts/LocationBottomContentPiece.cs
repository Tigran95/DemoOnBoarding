using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationBottomContentPiece : BottomContentPiecesBase
{
    public override void DoMove()
    {
        TweensManager.Instance.DoMoveBottomContent();
    }
}
