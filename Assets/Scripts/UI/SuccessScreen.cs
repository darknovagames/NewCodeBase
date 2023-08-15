using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DNBase.UI;
using TMPro;

public class SuccessScreen : UIScreen
{
    [SerializeField] AnimatableUI<Image> _background;
    [SerializeField] AnimatableUI<Button> _nextLevelButton;
    [SerializeField] AnimatableUI<Image> _emoji;
    [SerializeField] AnimatableUI<TextMeshProUGUI> _wellPlayedText;

    public override IEnumerator PlayInAnimation()
    {
        gameObject.SetActive(true);
        _background.PlayInAnimation(0.2f);
        _nextLevelButton.PlayInAnimation(0.2f);
        _emoji.PlayInAnimation(0.2f);
        _wellPlayedText.PlayInAnimation(0.2f);
        yield return null;
    }

    public override IEnumerator PlayOutAnimation()
    {
        _background.PlayOutAnimation(0.2f);
        _nextLevelButton.PlayOutAnimation(0.2f);
        _emoji.PlayOutAnimation(0.2f);
        _wellPlayedText.PlayOutAnimation(0.2f);
        gameObject.SetActive(false);
        yield return null;
    }

}
