using UnityEngine;

namespace WISUtilities.Core {
    [CreateAssetMenu(menuName = "WIS/Core/Value Objects/Float", fileName = "NewFloatObject", order = 0)]
    public class FloatObject : ScriptableObject {
        public float value;
    }
}