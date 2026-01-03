using MelonLoader;
using UnityEngine;
using Il2CppInterop;
using Il2CppInterop.Runtime.Injection; 
using System.Collections;
using Il2CppTLD.Gear;
using Il2Cpp;

namespace CaffeinatedSodas
{
	public class CaffeinatedSodasMelon : MelonMod
	{
		public override void OnInitializeMelon()
		{
            Settings.instance.AddToModSettings("Caffeinated Sodas");
            Settings.OnLoad();
        }


    }
}