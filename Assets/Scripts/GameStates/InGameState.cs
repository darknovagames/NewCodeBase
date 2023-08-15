using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DNBase.Core{
    public class InGameState : GameState
    {
        public override void OnStart()
        {
            LevelManager.Instance.LoadLevel();
        }

        public override void OnEnd()
        {
            
        }


        public override void OnTick()
        {
            
        }
    }
}