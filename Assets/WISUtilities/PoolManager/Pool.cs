using UnityEngine;
using WISUtilities.Core;

namespace WISUtilities.Pool {
    
    [CreateAssetMenu(menuName = "WIS/Pool", fileName = "NewPool", order = 0)]
    public class Pool : ScriptableObject {
        
        public StringObject poolTag;
        
        public Poolable poolObject;
        
        public int initialCount;
        
        public bool shouldExpand;
    }
}