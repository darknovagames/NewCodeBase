using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DNBase.UI;
using DNBase.Core;
using TMPro;

public class GameScreen : UIScreen
{
    [SerializeField] AnimatableUI<TextMeshProUGUI> _levelText;
    [SerializeField] AnimatableUI<Image> _levelTextBg;
    
    [SerializeField] AnimatableUI<TextMeshProUGUI> _moneyText;
    [SerializeField] AnimatableUI<Image> _moneyTextBg;

    private void Start(){
        EventManager.OnMoneyChanged += OnMoneyChanged;
    }

    public override IEnumerator PlayInAnimation()
    {
        gameObject.SetActive(true);
        _levelText.UIComponent.text = "LEVEL " + DataManager.Instance.GetLevel();
        _moneyText.UIComponent.text = "" + DataManager.Instance.GetMoney();
        yield return StartCoroutine(_levelText.PlayInAnimation(0.2f));
        yield return StartCoroutine(_levelTextBg.PlayInAnimation(0.2f));
        yield return StartCoroutine(_moneyText.PlayInAnimation(0.2f));
        yield return StartCoroutine(_moneyTextBg.PlayInAnimation(0.2f));
    }

    public override IEnumerator PlayOutAnimation()
    {
        yield return StartCoroutine(_levelText.PlayOutAnimation(0.2f));
        yield return StartCoroutine(_levelTextBg.PlayOutAnimation(0.2f));
        yield return StartCoroutine(_moneyText.PlayOutAnimation(0.2f));
        yield return StartCoroutine(_moneyTextBg.PlayOutAnimation(0.2f));
        gameObject.SetActive(false);
    }

    private void OnMoneyChanged(int money){
        _moneyText.UIComponent.text = "" + money;
    }
}
