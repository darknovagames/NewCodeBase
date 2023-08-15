using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DNBase.Core{

    public class EventManager : Singleton<EventManager>
    {
        public static event Action<int> OnMoneyChanged;
        public static event Action<int> OnLevelChanged;
        public static event Action<GameStateType> OnGameStateChanged;

        public void MoneyChanged(int money){
            if( OnMoneyChanged != null){
                OnMoneyChanged.Invoke(money);
            }
        }

        public void LevelChanged(int level){
            if( OnLevelChanged != null){
                OnLevelChanged.Invoke(level);
            }
        }

        public void GameStateChanged(GameStateType gameStateType){
            if( OnGameStateChanged != null){
                OnGameStateChanged.Invoke(gameStateType);
            }
        }
    }

}