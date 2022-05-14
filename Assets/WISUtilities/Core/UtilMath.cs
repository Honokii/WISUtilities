using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WISUtilities.Core {
    public static class UtilMath {
        public static float GetNoise(Vector2 pos, float noiseVal) {
            return Mathf.PerlinNoise(pos.x * noiseVal, pos.y * noiseVal);
        }
    }
}
