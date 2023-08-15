using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace DNBase.Core
{
    public class UIManager : Singleton<UIManager>
    {
        private UIScreen _activeScreen;

        [SerializeField] private MainScreen _mainScreen;
        [SerializeField] private GameScreen _gameScreen;
        [SerializeField] private FailScreen _failScreen;
        [SerializeField] private SuccessScreen _successScreen;

        protected override void Awake(){
            base.Awake();
            EventManager.OnGameStateChanged += OnGameStateChanged;
        }
        
        private void OnGameStateChanged(GameStateType gameStateType){
            if(gameStateType == GameStateType.menu){
                ChangeUI(_mainScreen);
            }
            if(gameStateType == GameStateType.game){
                ChangeUI(_gameScreen);
            }
            if(gameStateType == GameStateType.failed){
                ChangeUI(_failScreen);
            }
            if(gameStateType == GameStateType.success){
                ChangeUI(_successScreen);
            }
        }

        private void ChangeUI(UIScreen uIScreen){
            if(_activeScreen != null) StartCoroutine(_activeScreen.PlayOutAnimation());
            _activeScreen = uIScreen;
            if(_activeScreen != null) StartCoroutine(_activeScreen.PlayInAnimation());
        }
    }
}
