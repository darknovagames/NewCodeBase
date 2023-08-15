using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DNBase.Core{
    public abstract class GameState : MonoBehaviour
    {
        public virtual void OnStart() {}
        public virtual void OnTick() {}
        public virtual void OnEnd() {}
        public virtual void OnDown() {}
        public virtual void OnUp() {}
        public virtual void OnDrag() {}
    }
}
