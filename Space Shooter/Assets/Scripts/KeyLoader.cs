using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using System;

public class KeyLoader : MonoBehaviour
{
    public void Start()
    {
        string exeyolu = @"C:\Users\pegas\OneDrive\Masaüstü\Space Shooter Game\Unity-Template\Unity_Engine_Settings\Unity_Engine_Settings\bin\Release\net6.0-windows\Unity_Engine_Settings.exe";
        System.Diagnostics.Process.Start(exeyolu);
    }

   
}
