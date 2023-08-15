using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DNBase.Core{
    public class SuccessState : GameState
    {
        public override void OnStart()
        {
            DataManager.Instance.SetLevel(DataManager.Instance.GetLevel() + 1);
        }

        public override void OnEnd()
        {
            
        }


        public override void OnTick()
        {
            
        }
    }
}