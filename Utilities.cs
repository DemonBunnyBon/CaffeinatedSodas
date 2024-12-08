using UnityEngine;
using Il2Cpp;
using MelonLoader;





namespace CaffeinatedSodas
{
    internal static class CaffeinatedSodasUtils
    {

        public static bool IsScenePlayable(string scene)
        {
            return !(string.IsNullOrEmpty(scene) || scene.Contains("MainMenu") || scene == "Boot" || scene == "Empty");
        }




    }






}