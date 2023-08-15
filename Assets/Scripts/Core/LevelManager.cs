using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DNBase.Core
{
    public class LevelManager : Singleton<LevelManager>
    {
        [SerializeField] private Level[] allLevels;
        [SerializeField] private Transform levelHolder;

        public static Level ActiveLevel { get; private set; }

        /*
        private void Start()
        {
            ActiveLevel = CreateLevel();
        }*/

        /// <summary>
        /// Creates test level if exists, otherwise creates next level.
        /// </summary>
        /// <returns></returns>

        private Level CreateLevel()
        {
            Level level = Instantiate(allLevels[DataManager.Instance.GetLevel() % allLevels.Length],
                levelHolder);
            return level;
        }

        public void LoadLevel(){
            ActiveLevel = CreateLevel();
            EventManager.Instance.LevelChanged(DataManager.Instance.GetLevel());
        }
    }

}