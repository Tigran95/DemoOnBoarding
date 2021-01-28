using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class NextPanelClickButton : Selectable
{
    [SerializeField] private ViewContentPiecesBase _viewContentElement;
    [SerializeField] private BottomContentPiecesBase _bottomContentElement;

    public override void OnPointerUp(PointerEventData eventData)
    {
        enabled = false;
        _viewContentElement.DoMove();
        _bottomContentElement.DoMove();
    }
}
