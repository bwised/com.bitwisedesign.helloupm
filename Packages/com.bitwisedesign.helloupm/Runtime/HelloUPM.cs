using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BitwiseDesign
{
    public class HelloUPM : MonoBehaviour
    {
        public string awakeText = "Hello UPM!";

        void Awake()
        {
            Debug.Log(awakeText);
            HelloUPMPlugin.Execute();
        }
    }
}
