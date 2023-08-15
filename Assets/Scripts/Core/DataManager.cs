using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DNBase.Core{
    public class DataManager : Singleton<DataManager>
    {
        private void Start() {
            if(!PlayerPrefs.HasKey(GameConstants.MONEY_KEY))
            {
                PlayerPrefs.SetInt(GameConstants.MONEY_KEY, 0);
            }
            if(!PlayerPrefs.HasKey(GameConstants.LEVEL_KEY))
            {
                PlayerPrefs.SetInt(GameConstants.LEVEL_KEY, 1);
            }
        }

        public int GetLevel(){
            return PlayerPrefs.GetInt(GameConstants.LEVEL_KEY);;
        }

        public int GetMoney(){
            return PlayerPrefs.GetInt(GameConstants.MONEY_KEY);;
        }

        public void SetMoney(int money){
            PlayerPrefs.SetInt(GameConstants.MONEY_KEY, money);
        }

        public void SetLevel(int level){
            PlayerPrefs.SetInt(GameConstants.LEVEL_KEY, level);
        }
    }
}
