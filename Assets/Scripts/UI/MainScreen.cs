using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DNBase.UI;
using DNBase.Core;
using TMPro;

public class MainScreen : UIScreen
{
    [SerializeField] AnimatableUI<Button> _playButton;

    public override IEnumerator PlayInAnimation()
    {
        gameObject.SetActive(true);
        yield return StartCoroutine(_playButton.PlayInAnimation(0.2f));
    }

    public override IEnumerator PlayOutAnimation()
    {
        yield return StartCoroutine(_playButton.PlayOutAnimation(0.2f));
        gameObject.SetActive(false);
    }

    public void OnPlayButtonPressed(){
        GameManager.Instance.StartGame();
    }
}
