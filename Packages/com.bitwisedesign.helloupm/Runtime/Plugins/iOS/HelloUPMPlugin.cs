using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class HelloUPMPlugin
{
#if UNITY_IPHONE
    [DllImport("__Internal")]
    private static extern void _helloNative();
#endif

    public static void Execute()
    {
        Debug.Log("Hello Native - Start");
        if (!Application.isEditor)
        {
#if UNITY_IPHONE
            _helloNative();
#endif
        }
        else
        {
            Debug.Log("Hello Native Editor");
        }
        Debug.Log("Hello Native - Done");
    }
}
