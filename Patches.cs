namespace CaffeinatedSodas;

[HarmonyPatch(typeof(GearItem),nameof(GearItem.Awake))]
internal class SodaPatches
{
    static void Postfix(ref GearItem __instance)
    {
        //Orange
        if (__instance.name.Contains("GEAR_SodaOrange"))
        {
            if(Settings.instance.Orange)
            {
                FatigueBuff f =__instance.gameObject.AddComponent<FatigueBuff>();
                __instance.m_FatigueBuff = f;
                f.m_InitialPercentDecrease = Settings.instance.OrangeInitial;
                f.m_RateOfIncreaseScale = 1;
                switch (Settings.instance.OrangeDuration)
                {
                    case 0:
                        f.m_DurationHours = CaffeinatedSodasUtils.duration_small();
                        break;
                    case 1:
                        f.m_DurationHours = CaffeinatedSodasUtils.duration_medium();
                        break;
                    case 2:
                        f.m_DurationHours = CaffeinatedSodasUtils.duration_long();
                        break;
                    case 3:
                        f.m_DurationHours = CaffeinatedSodasUtils.duration_verylong();
                        break;
                }
            }
        }


            //Summit
            if (__instance.name.Contains("GEAR_Soda") && !__instance.name.Contains("GEAR_SodaOrange") && !__instance.name.Contains("GEAR_SodaGrape"))
            {
                if (Settings.instance.Summit)
                {
                    FatigueBuff f = __instance.gameObject.AddComponent<FatigueBuff>();
                    __instance.m_FatigueBuff = f;
                    f.m_InitialPercentDecrease = Settings.instance.SummitInitial;
                    f.m_RateOfIncreaseScale = 1;
                    switch (Settings.instance.SummitDuration)
                    {
                        case 0:
                            f.m_DurationHours = CaffeinatedSodasUtils.duration_small();
                            break;
                        case 1:
                            f.m_DurationHours = CaffeinatedSodasUtils.duration_medium();
                            break;
                        case 2:
                            f.m_DurationHours = CaffeinatedSodasUtils.duration_long();
                            break;
                        case 3:
                            f.m_DurationHours = CaffeinatedSodasUtils.duration_verylong();
                            break;
                    }
                }
            }
            

            //Grape
            if (__instance.name.Contains("GEAR_SodaGrape"))
            {
                if(Settings.instance.Grape)
                {
                    FatigueBuff f =__instance.gameObject.AddComponent<FatigueBuff>();
                    __instance.m_FatigueBuff = f;
                    f.m_InitialPercentDecrease = Settings.instance.GrapeInitial;
                    f.m_RateOfIncreaseScale = 1;
                    switch (Settings.instance.GrapeDuration)
                    {
                        case 0:
                            f.m_DurationHours = CaffeinatedSodasUtils.duration_small();
                            break;
                        case 1:
                            f.m_DurationHours = CaffeinatedSodasUtils.duration_medium();
                            break;
                        case 2:
                            f.m_DurationHours = CaffeinatedSodasUtils.duration_long();
                            break;
                        case 3:
                            f.m_DurationHours = CaffeinatedSodasUtils.duration_verylong();
                            break;
                    }
                }
            }
    }
}