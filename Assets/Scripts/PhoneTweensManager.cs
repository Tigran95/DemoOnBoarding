using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class PhoneTweensManager : MonoBehaviour
{
    public static PhoneTweensManager Instance;
    private void Awake()
    {
        Instance = this;
    }


    [SerializeField] private RectTransform _phoneFirstDestination;
    [SerializeField] private RectTransform _phoneFinalDestination;
    [SerializeField] private RectTransform _infoPiecesRect;
    [SerializeField] private float _phoneTweenSpeed;

    private RectTransform _thisRect;

    private void Start()
    {
        _thisRect = GetComponent<RectTransform>();
    }
    public void DoFirstTween()
    {
        var seq = DOTween.Sequence();
        seq.Append(GetComponent<RectTransform>().DOAnchorPos(_phoneFirstDestination.anchoredPosition, _phoneTweenSpeed));
    }

    public Sequence DoLastTween()
    {
        var seq = DOTween.Sequence();
        seq.Join(_thisRect.DOAnchorPos(_phoneFinalDestination.anchoredPosition, _phoneTweenSpeed));
        Vector2 newSizeDelta = new Vector2(_thisRect.sizeDelta.x * 1.17f, _thisRect.sizeDelta.y * 1.17f);
        seq.Join(_thisRect.DOSizeDelta(newSizeDelta, _phoneTweenSpeed));
        return seq;
    }

    public void DoBookModelTween()
    {
        var seq = DOTween.Sequence();
        seq.Append(_infoPiecesRect.DOAnchorPos(new Vector2(0, 0), _phoneTweenSpeed));
    }
}
