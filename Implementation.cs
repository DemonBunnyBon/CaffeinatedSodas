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

		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			if(CaffeinatedSodasUtils.IsScenePlayable(sceneName))
			{
                ChangeItemProperties();
            }

			


        }

        public static void ChangeItemProperties()
		{
            GameObject gear;
			float small = 0.085f; //5 minutes
			float medium = 0.167f; //10 minutes
			float big = 0.25f; //15 minutes
			float verybig = 0.5f; //30 minutes

			//Orange
			gear = GearItem.LoadGearItemPrefab("GEAR_SodaOrange").gameObject;
			if(Settings.instance.Orange==true)
			{
                gear.AddComponent<FatigueBuff>();
                gear.GetComponent<FatigueBuff>().m_InitialPercentDecrease = Settings.instance.OrangeInitial;
                gear.GetComponent<FatigueBuff>().m_RateOfIncreaseScale = 1;
                switch (Settings.instance.OrangeDuration)
				{
					case 0:
						gear.GetComponent<FatigueBuff>().m_DurationHours = small;
						break;
					case 1:
						gear.GetComponent<FatigueBuff>().m_DurationHours = medium;
						break;
					case 2:
						gear.GetComponent<FatigueBuff>().m_DurationHours = big;
						break;
					case 3:
						gear.GetComponent<FatigueBuff>().m_DurationHours = verybig;
						break;
				}
            }
			else
			{
				GameManager.DestroyImmediate(gear.GetComponent<FatigueBuff>());
			}

            //Summit
            gear = GearItem.LoadGearItemPrefab("GEAR_Soda").gameObject;
            if (Settings.instance.Summit == true)
            {
                gear.AddComponent<FatigueBuff>();
                gear.GetComponent<FatigueBuff>().m_InitialPercentDecrease = Settings.instance.SummitInitial;
                gear.GetComponent<FatigueBuff>().m_RateOfIncreaseScale = 1;
                switch (Settings.instance.SummitDuration)
                {
                    case 0:
                        gear.GetComponent<FatigueBuff>().m_DurationHours = small;
                        break;
                    case 1:
                        gear.GetComponent<FatigueBuff>().m_DurationHours = medium;
                        break;
                    case 2:
                        gear.GetComponent<FatigueBuff>().m_DurationHours = big;
                        break;
                    case 3:
                        gear.GetComponent<FatigueBuff>().m_DurationHours = verybig;
                        break;
                }
            }
            else
            {
                GameManager.DestroyImmediate(gear.GetComponent<FatigueBuff>());
            }

            //Grape
            gear = GearItem.LoadGearItemPrefab("GEAR_SodaGrape").gameObject;
            if (Settings.instance.Grape == true)
            {
                gear.AddComponent<FatigueBuff>();
                gear.GetComponent<FatigueBuff>().m_InitialPercentDecrease = Settings.instance.GrapeInitial;
                gear.GetComponent<FatigueBuff>().m_RateOfIncreaseScale = 1;
                switch (Settings.instance.GrapeDuration)
                {
                    case 0:
                        gear.GetComponent<FatigueBuff>().m_DurationHours = small;
                        break;
                    case 1:
                        gear.GetComponent<FatigueBuff>().m_DurationHours = medium;
                        break;
                    case 2:
                        gear.GetComponent<FatigueBuff>().m_DurationHours = big;
                        break;
                    case 3:
                        gear.GetComponent<FatigueBuff>().m_DurationHours = verybig;
                        break;
                }
            }
            else
            {
                GameManager.DestroyImmediate(gear.GetComponent<FatigueBuff>());
            }

        }

    }
}