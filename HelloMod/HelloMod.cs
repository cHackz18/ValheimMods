using System;
using BepInEx;

namespace HelloMod
{
    [BepInPlugin("github.com.cHackz18.ValheimMods.HelloWorld", "Hello World Plugin", "1.0.0.0")]
    [BepInProcess("valheim.exe")]
    public class HelloMod : BaseUnityPlugin
    {
        void Awake()
        {
            UnityEngine.Debug.Log("Hello, World");
        }
    }
}
