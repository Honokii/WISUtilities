using UnityEngine;

namespace WISUtilities.Core {
    public static class Utils {
        private static Camera _camera;

        public static Camera GetCamera {
            get {
                if (_camera == null)
                    _camera = Camera.main;

                return _camera;
            }
        }
    }
}