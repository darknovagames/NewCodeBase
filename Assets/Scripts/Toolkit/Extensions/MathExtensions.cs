using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DNBase.Toolkit.Extensions{
    public static class MathExtensions
    {
        public static Matrix4x4 MatrixLerp(this Matrix4x4 from, Matrix4x4 to, float time)
        {
            Matrix4x4 ret = new Matrix4x4();
            for (int i = 0; i < 16; i++)
                ret[i] = Mathf.Lerp(from[i], to[i], time);
            return ret;
        }
    }
}
