using UnityEngine;

namespace WISUtilities.Core {
    [CreateAssetMenu(menuName = "WIS/Core/Value Objects/String", fileName = "NewStringObject", order = 0)]
    public class StringObject : ScriptableObject {
        public string value;
    }
}
