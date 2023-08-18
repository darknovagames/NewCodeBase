using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DNBase.Core{
    //General game manager script that controls game flow.
    public class GameManager : Singleton<GameManager>
    {
        private GameState _currentState;

        private void Start() {
            ChangeGameState(GameStateType.menu);
        }

        private void Update(){
            if(Input.touchCount>0){
                if(Input.GetTouch(0).phase == TouchPhase.Began){
                    _currentState.OnDown();
                }
                else if(Input.GetTouch(0).phase == TouchPhase.Moved){
                    _currentState.OnDrag();
                }
                else if(Input.GetTouch(0).phase == TouchPhase.Ended){
                    _currentState.OnUp();
                }
            }
        }

        public void LevelSuccess(){
            ChangeGameState(GameStateType.success);
        }

        public void LevelFailed(){
            ChangeGameState(GameStateType.failed);
        }

        public void StartGame(){
            ChangeGameState(GameStateType.game);
        }

        private void ChangeGameState(GameState gameState){
            if(_currentState != null) _currentState.OnEnd();
            _currentState = gameState;
            if(_currentState != null) _currentState.OnStart();
        }

        public void ChangeGameState(GameStateType gameStateType){
            GameState gameState = gameStateType switch 
            {
                GameStateType.menu => menuState,
                GameStateType.failed => failedState,
                GameStateType.success => successState,
                GameStateType.game => inGameState,
                _ => throw new ArgumentOutOfRangeException(nameof(gameStateType), gameStateType, null)
            };
            EventManager.Instance.GameStateChanged(gameStateType);
            ChangeGameState(gameState);
        }

        [SerializeField] private GameState menuState;
        [SerializeField] private GameState failedState;
        [SerializeField] private GameState successState;
        [SerializeField] private GameState inGameState;
        
    }

}
