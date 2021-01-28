using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CheckListElement : MonoBehaviour
{

    [SerializeField] private Image _logo;
    [SerializeField] private Sprite _checkedLogoSprite;
    [SerializeField] private Text _infoText1;
    [SerializeField] private Text _infoText2;
    public void DoCheck()
    {
        _logo.sprite = _checkedLogoSprite;
        GetComponent<Selectable>().enabled = false;
        _infoText1.color = new Color(_infoText1.color.r, _infoText1.color.g, _infoText1.color.b, _infoText1.color.a - 0.3f);
        _infoText2.color = new Color(_infoText2.color.r, _infoText2.color.g, _infoText2.color.b, _infoText2.color.a - 0.3f);
    }
}
