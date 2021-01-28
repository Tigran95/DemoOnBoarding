using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class TweensManager : MonoBehaviour
{

    public static TweensManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    [SerializeField] private RectTransform _viewContent;
    [SerializeField] private RectTransform _baseBottomContent;
    [SerializeField] private RectTransform _checkListContent;
    [SerializeField] private float _horisontalTweenSpeed;
    private float _horisontalStepSize;
    [SerializeField] private float _checklistTweenSpeed;
    
    private IEnumerator Start()
    {
        _horisontalStepSize = -FindObjectOfType<CanvasScaler>().referenceResolution.x;
        yield return new WaitForSeconds(1.5f);
        DoMoveViewContent();
        DoMoveBottomContent();
    }

    public Sequence DoMoveViewContent()
    {
        var seq = DOTween.Sequence();
        seq.Join(_viewContent.DOAnchorPosX(_viewContent.anchoredPosition.x+ _horisontalStepSize, _horisontalTweenSpeed));
        return seq;
    }
    public Sequence DoMoveBottomContent()
    {
        var seq = DOTween.Sequence();
        seq.Join(_baseBottomContent.DOAnchorPosX(_baseBottomContent.anchoredPosition.x + _horisontalStepSize, _horisontalTweenSpeed));
        return seq;
    }

    public void DoMoveCheckList()
    {
        var seq = DOTween.Sequence();
        seq.Append(_checkListContent.DOAnchorPos(new Vector2(0, 0), _checklistTweenSpeed));
    }
}
