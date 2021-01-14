using UIKit.Runtime;
using UnityEditor;
using UnityEngine;

namespace UIKit.Editor
{
    public class UIKitEditor
    {
        [MenuItem("UIKit/Test")]
        public static void Test()
        {
            UITest test = new UITest();
            test.Init();
            Debug.Log("Test");
        }
    }
}


