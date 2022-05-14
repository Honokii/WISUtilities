using UnityEngine;

namespace WISUtilities.Core {
    [CreateAssetMenu(menuName = "WIS/Core/String Object", fileName = "NewStringObject", order = 0)]
    public class StringObject : ScriptableObject {
        public string value;
    }
}
